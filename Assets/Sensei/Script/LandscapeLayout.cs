using UnityEngine;
using UnityEngine.UI;

// Backgrounds fill the canvas; interactive panels stay inside the safe area.
[RequireComponent(typeof(Canvas), typeof(CanvasScaler))]
[DefaultExecutionOrder(-100)]
public class LandscapeLayout : MonoBehaviour
{
    private RectTransform _safeArea;
    private CanvasScaler _scaler;
    private Rect _lastSafeArea;
    private Vector2Int _lastScreen;

    public void Initialize(RectTransform navigation)
    {
        _scaler = GetComponent<CanvasScaler>();
        if (_safeArea == null)
        {
            _safeArea = new GameObject("SafeArea", typeof(RectTransform), typeof(RectMask2D)).GetComponent<RectTransform>();
            _safeArea.gameObject.layer = navigation.gameObject.layer;
            _safeArea.SetParent(transform, false);
            _safeArea.SetSiblingIndex(navigation.GetSiblingIndex());
        }
        navigation.SetParent(_safeArea, false);
        var background = transform.Find("Background") as RectTransform;
        if (background != null)
        {
            Stretch(background);
            foreach (var layer in new[] { "HomeBG", "LeftBG", "RightBG" })
            {
                var rect = background.Find(layer) as RectTransform;
                if (rect != null) Stretch(rect);
            }
        }
        if (background != null)
        {
            var left = background.Find("HeroLeft") as RectTransform;
            var right = background.Find("HeroRight") as RectTransform;
            if (left != null) PlacePortrait(left, false);
            if (right != null) PlacePortrait(right, true);
        }
        Apply();
        Canvas.ForceUpdateCanvases();
    }

    private static void Stretch(RectTransform rect)
    {
        rect.anchorMin = Vector2.zero;
        rect.anchorMax = Vector2.one;
        rect.offsetMin = rect.offsetMax = Vector2.zero;
    }

    private void PlacePortrait(RectTransform portrait, bool right)
    {
        if (portrait.parent == _safeArea) return;
        // Translate the original centered 2340 x 1080 offsets into safe bottom corners.
        var offset = portrait.anchoredPosition + new Vector2(right ? -1170 : 1170, 540);
        portrait.SetParent(_safeArea, false);
        portrait.SetAsFirstSibling();
        portrait.anchorMin = portrait.anchorMax = new Vector2(right ? 1 : 0, 0);
        portrait.anchoredPosition = offset;
    }

    private void Update()
    {
        if (_safeArea != null && (_lastSafeArea != Screen.safeArea || _lastScreen != new Vector2Int(Screen.width, Screen.height)))
            Apply();
    }

    private void Apply()
    {
        _lastSafeArea = Screen.safeArea;
        _lastScreen = new Vector2Int(Screen.width, Screen.height);
        ApplyViewport(_lastSafeArea, _lastScreen);
    }

    private void ApplyViewport(Rect safe, Vector2Int screen)
    {
        if (screen.x <= 0 || screen.y <= 0) return;
        if (safe.width <= 0 || safe.height <= 0) safe = new Rect(0, 0, screen.x, screen.y);
        _scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        _scaler.scaleFactor = Mathf.Min(safe.width / 2340f, safe.height / 1080f);
        GetComponent<Canvas>().scaleFactor = _scaler.scaleFactor;
        _safeArea.anchorMin = new Vector2(safe.xMin / screen.x, safe.yMin / screen.y);
        _safeArea.anchorMax = new Vector2(safe.xMax / screen.x, safe.yMax / screen.y);
        _safeArea.offsetMin = _safeArea.offsetMax = Vector2.zero;
    }
}
