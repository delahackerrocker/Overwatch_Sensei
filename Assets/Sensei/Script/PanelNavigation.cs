using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanelNavigation : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 panelLocation;
    public float percentThreshold = 0.35f;

    Vector3 panelSize = new Vector3(2340f, 1080f, 0f);

    void Start()
    {
        panelLocation = transform.position;
    }

    void Update()
    {
        
    }

    public void OnDrag(PointerEventData data)
    {
        Debug.Log(data.pressPosition - data.position);

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
            if (Mathf.Abs(yPercentage) >= percentThreshold)
            {
                Vector3 newLocation = panelLocation;
                if (yPercentage > 0)
                {
                    newLocation += new Vector3(0, -panelSize.y, 0);
                }
                else if (yPercentage < 0)
                {
                    newLocation += new Vector3(0, panelSize.y, 0);
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
            if (Mathf.Abs(xPercentage) >= percentThreshold)
            {
                Vector3 newLocation = panelLocation;
                if (xPercentage > 0)
                {
                    newLocation += new Vector3(-panelSize.x, 0, 0);
                }
                else if (xPercentage < 0)
                {
                    newLocation += new Vector3(panelSize.x, 0, 0);
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
