using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

[RequireComponent(typeof(RectTransform))]
public class PanelNavigation : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static PanelNavigation Instance { get; private set; }

    // Kept for scene compatibility; now a canvas-local destination.
    public Vector3 panelLocation;
    [Tooltip("Fraction of the viewport required to change panels. The original scene uses zero.")]
    public float percentThreshold = 25f;
    public PanelNode currentlySelected;
    public PanelNode PickHero;
    public PanelNode HeroTasks;
    public PanelNode HeroKit;
    public PanelNode HeroAbilityDetails;
    public PanelNode HeroCounterPicks;
    public PanelNode HeroVersusHero;
    public PanelNode HeroVersusHero_Previous;
    public PanelNode HeroVersusHero_Next;
    public PanelNode NextHeroAbilityDetails;

    private RectTransform _rect;
    private RectTransform _viewport;
    private Vector2 _panelSize;
    private Vector2 _dragOrigin;
    private PointerEventData _lastPointerData;
    private Tween _transition;
    private bool _cancelledDrag;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); return; }
        Instance = this;
        _rect = (RectTransform)transform;
    }

    private void Start()
    {
        var canvas = GetComponentInParent<Canvas>();
        if (canvas != null)
        {
            var layout = canvas.GetComponent<LandscapeLayout>();
            if (layout == null) layout = canvas.gameObject.AddComponent<LandscapeLayout>();
            layout.Initialize(_rect);
        }
        _viewport = (RectTransform)_rect.parent;
        RefreshLayout();
    }

    private void Update()
    {
        if (_viewport != null && _viewport.rect.size != _panelSize) RefreshLayout();
        if (Main.Instance == null) return;
        if (currentlySelected == PickHero)
        {
            Main.Instance.selectedHero = HERO_ID.None;
            Main.Instance.counterPick = HERO_ID.None;
            Main.Instance.selectedAbility = null;
        }
        if (currentlySelected == HeroTasks) Main.Instance.counterPick = HERO_ID.None;
        if (currentlySelected == HeroVersusHero && Main.Instance.counterPick == HERO_ID.None)
            Main.Instance.counterPick = HERO_ID.Ana;
    }

    public void RefreshLayout()
    {
        if (_viewport == null) return;
        var size = _viewport.rect.size;
        if (size.x <= 0 || size.y <= 0) return;
        CancelDrag();
        _transition?.Kill();
        _panelSize = size;
        _rect.anchorMin = _rect.anchorMax = _rect.pivot = new Vector2(0.5f, 0.5f);
        _rect.sizeDelta = size;
        // Preserve the authored arrangement, independent of viewport pixels.
        Place(PickHero, 0, 0);
        Place(HeroTasks, 0, -1);
        Place(HeroKit, -1, -1);
        Place(HeroAbilityDetails, -2, -1);
        Place(HeroCounterPicks, 1, -1);
        Place(HeroVersusHero, 0, -2);
        Place(HeroVersusHero_Previous, -1, -2);
        Place(HeroVersusHero_Next, 1, -2);
        Place(NextHeroAbilityDetails, -3, -1);
        var splash = _rect.Find("StartSplash") as RectTransform;
        if (splash != null) { splash.sizeDelta = size; splash.anchoredPosition = Vector2.zero; }
        if (currentlySelected == null) currentlySelected = PickHero;
        panelLocation = Destination(currentlySelected);
        _rect.anchoredPosition = panelLocation;
    }

    private void Place(PanelNode node, int x, int y)
    {
        if (node == null) return;
        var rect = (RectTransform)node.transform;
        rect.anchorMin = rect.anchorMax = rect.pivot = new Vector2(0.5f, 0.5f);
        rect.sizeDelta = _panelSize;
        rect.anchoredPosition = new Vector2(x * _panelSize.x, y * _panelSize.y);
    }

    private Vector2 Destination(PanelNode node)
    {
        return node == null ? Vector2.zero : -((RectTransform)node.transform).anchoredPosition;
    }

    public void GOTO_PickHero() => GoTo(PickHero);
    public void GOTO_HeroTasks() => GoTo(HeroTasks);
    public void GOTO_HeroKit() => GoTo(HeroKit);
    public void GOTO_HeroAbilityDetails() => GoTo(HeroAbilityDetails);
    public void GOTO_HeroVersusHero() => GoTo(HeroVersusHero);
    public void GOTO_HeroCounterPicks() => GoTo(HeroCounterPicks);

    private void GoTo(PanelNode node)
    {
        if (node == null) return;
        CancelDrag();
        currentlySelected = node;
        Transition(Destination(node));
    }

    protected void Transition(Vector3 newLocation)
    {
        _transition?.Kill();
        panelLocation = newLocation;
        _transition = _rect.DOAnchorPos(newLocation, 0.5f, true).SetEase(Ease.OutQuint);
    }

    public void CancelDrag()
    {
        if (_lastPointerData == null) return;
        _lastPointerData.pointerDrag = null;
        _lastPointerData = null;
        _cancelledDrag = true;
    }

    public void OnBeginDrag(PointerEventData data)
    {
        if (currentlySelected == null) return;
        _transition?.Kill();
        _lastPointerData = data;
        _cancelledDrag = false;
        _dragOrigin = _rect.anchoredPosition;
    }

    private Vector2 Displacement(PointerEventData data)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_viewport, data.pressPosition, data.pressEventCamera, out var start);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(_viewport, data.position, data.pressEventCamera, out var end);
        return start - end;
    }

    public void OnDrag(PointerEventData data)
    {
        if (currentlySelected == null || _viewport == null) return;
        if (_lastPointerData != data) OnBeginDrag(data);
        var difference = Displacement(data);
        if (!currentlySelected.HasLeft() && !currentlySelected.HasRight()) difference.x = 0;
        if (!currentlySelected.HasAbove() && !currentlySelected.HasBelow()) difference.y = 0;
        _rect.anchoredPosition = _dragOrigin - difference;
    }

    public void OnEndDrag(PointerEventData data)
    {
        if (_cancelledDrag || currentlySelected == null || _viewport == null) return;
        _lastPointerData = null;
        var difference = Displacement(data);
        float x = difference.x / _panelSize.x;
        float y = difference.y / _panelSize.y;
        PanelNode next = null;
        bool horizontal = Mathf.Abs(x) > Mathf.Abs(y);
        if (Mathf.Abs(y) > Mathf.Abs(x) && Mathf.Abs(y) >= percentThreshold)
            next = y > 0 ? currentlySelected.above : currentlySelected.below;
        else if (horizontal && Mathf.Abs(x) >= percentThreshold)
            next = x > 0 ? currentlySelected.right : currentlySelected.left;

        if (next != null)
        {
            GoTo(next);
            if (horizontal && (next == HeroVersusHero_Next || next == HeroVersusHero_Previous))
                next.GetComponent<HeroVersusHero>().GoToHero();
            if (horizontal && next == NextHeroAbilityDetails)
                next.GetComponent<NextHeroAbility>().GoToNext();
        }
        else
        {
            bool committed = (horizontal && Mathf.Abs(x) >= percentThreshold) ||
                (Mathf.Abs(y) > Mathf.Abs(x) && Mathf.Abs(y) >= percentThreshold);
            if (committed) Transition(Destination(currentlySelected));
            else
            {
                _transition?.Kill();
                _rect.anchoredPosition = Destination(currentlySelected);
                panelLocation = _rect.anchoredPosition;
            }
        }
    }

    private void OnDisable()
    {
        CancelDrag();
        _transition?.Kill();
        if (_rect != null) _rect.anchoredPosition = panelLocation;
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }
}
