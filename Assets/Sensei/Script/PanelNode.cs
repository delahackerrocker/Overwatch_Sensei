 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum RelativePosition
{
    ABOVE,
    BELOW,
    LEFT,
    RIGHT
}

public class PanelNode : MonoBehaviour
{
    public PanelNode above = null;
    public PanelNode below = null;
    public PanelNode left = null;
    public PanelNode right = null;

    public bool HasAbove()
    {
        if (above != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool HasBelow()
    {
        if (below != null)
        {
            return true;
        } else
        {
            return false;
        }
    }
    public bool HasLeft()
    {
        if (left != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool HasRight()
    {
        if (right != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}