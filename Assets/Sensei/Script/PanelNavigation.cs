using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelNavigation : MonoBehaviour, IDragHandler, IEndDragHandler
{
    // Singleton
    public static PanelNavigation Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // ----
    private PointerEventData _lastPointerData;

    public Vector3 panelLocation;
    public float percentThreshold = 0.35f;

    Vector3 panelSize = new Vector3(2340f, 1080f, 0f);

    public PanelNode currentlySelected = null;

    public PanelNode PickHero;
    public PanelNode HeroTasks;
    public PanelNode HeroKit;
    public PanelNode HeroAbilityDetails;
    public PanelNode HeroVersusHero;
    public PanelNode HeroCounterPicks;

    void Start()
    {
        panelLocation = transform.position;
    }
    void Update()
    {
        if (currentlySelected == PickHero)
        {
            Main.Instance.selectedHero = HERO_ID.None;
            Main.Instance.counterPick = HERO_ID.None;
        }
        if (currentlySelected == HeroTasks)
        {
            Main.Instance.counterPick = HERO_ID.None;
        }
        if (currentlySelected == HeroVersusHero)
        {
            if (Main.Instance.counterPick == HERO_ID.None)
            {
                Main.Instance.counterPick = HERO_ID.Ana;
            }
        }
    }

    public void GOTO_PickHero()
    {
        CancelDrag();
        currentlySelected = PickHero;
        gameObject.transform.position = panelLocation = new Vector3(1170, 0, 0);
    }

    public void GOTO_HeroTasks()
    {
        CancelDrag();
        currentlySelected = HeroTasks;
        gameObject.transform.position = panelLocation = new Vector3(1170, 1620, 0);
    }
    public void GOTO_HeroKit()
    {
        CancelDrag();
        currentlySelected = HeroKit;
        gameObject.transform.position = panelLocation = new Vector3(3510, 1620, 0);
    }
    public void GOTO_HeroAbilityDetails()
    {
        CancelDrag();
        currentlySelected = HeroAbilityDetails;
        gameObject.transform.position = panelLocation = new Vector3(5850, 1620, 0);
    }
    public void GOTO_HeroVersusHero()
    {
        CancelDrag();
        currentlySelected = HeroVersusHero;
        gameObject.transform.position = panelLocation = new Vector3(1170, 2700, 0);
    }
    public void GOTO_HeroCounterPicks()
    {
        CancelDrag();
        currentlySelected = HeroCounterPicks;
        gameObject.transform.position = panelLocation = new Vector3(-1170, 1620, 0);
    }

    public void CancelDrag()
    {
        if (_lastPointerData != null)
        {
            _lastPointerData.pointerDrag = null;

            // Reset position here
        }
    }
    
    public void OnDrag(PointerEventData data)
    {
        // Debug.Log(data.pressPosition - data.position);

        float xDifference = data.pressPosition.x - data.position.x;
        float yDifference = data.pressPosition.y - data.position.y;
        transform.position = panelLocation - new Vector3(xDifference, yDifference, 0);

        DebugOverlay.Output("xDifference: " + xDifference+ ", yDifference: " + yDifference);
    }
    public void OnEndDrag(PointerEventData data)
    {
        float xPercentage = (data.pressPosition.x - data.position.x) / panelSize.x;
        float yPercentage = (data.pressPosition.y - data.position.y) / panelSize.y;

        if (Mathf.Abs(yPercentage) > Mathf.Abs(xPercentage))
        {
            // A Vertical Swipe Occurred
            if (Mathf.Abs(yPercentage) >= percentThreshold)
            {
                Vector3 newLocation = panelLocation;
                if (yPercentage > 0)
                {
                    // upward swipe; is there a panel above?
                    if (currentlySelected.HasAbove())
                    {
                        DebugOverlay.Output("Vertical swipe down");
                        // go to panel above
                        newLocation += new Vector3(0, -panelSize.y, 0);

                        currentlySelected = currentlySelected.above;
                    }
                }
                else if (yPercentage < 0)
                {
                    // downward swipe; is there a panel below?
                    if (currentlySelected.HasBelow())
                    {
                        DebugOverlay.Output("Vertical swipe up");
                        // go to panel below
                        newLocation += new Vector3(0, panelSize.y, 0);

                        currentlySelected = currentlySelected.below;
                    }
                } else
                {
                    // not a valid move reset position
                    newLocation = panelLocation;
                }
                transform.position = newLocation;
                panelLocation = newLocation;
            }
            else
            {
                transform.position = panelLocation;
            }
        } else if (Mathf.Abs(xPercentage) > Mathf.Abs(yPercentage))
        {
            // A Horizontal Swipe Occurred
            if (Mathf.Abs(xPercentage) >= percentThreshold)
            {
                Vector3 newLocation = panelLocation;
                if (xPercentage > 0)
                {
                    // Left swipe; is there a panel to the right?
                    if (currentlySelected.HasRight())
                    {
                        DebugOverlay.Output("Horizontal swipe left: " + currentlySelected.right.name);
                        // go to panel to the right
                        newLocation += new Vector3(-panelSize.x, 0, 0);

                        currentlySelected = currentlySelected.right;
                    }
                }
                else if (xPercentage < 0)
                {
                    // Right swipe; is there a panel to the left?
                    if (currentlySelected.HasLeft())
                    {
                        DebugOverlay.Output("Horizontal swipe right: " + currentlySelected.left.name);
                        // go to panel to the left
                        newLocation += new Vector3(panelSize.x, 0, 0);

                        currentlySelected = currentlySelected.left;
                    } else
                    {
                        // not a valid move reset position
                        newLocation = panelLocation;
                    }
                }
                transform.position = newLocation;
                panelLocation = newLocation;
            }
            else
            {
                transform.position = panelLocation;
            }
        } else
        {
            transform.position = panelLocation;
        }
    }
}