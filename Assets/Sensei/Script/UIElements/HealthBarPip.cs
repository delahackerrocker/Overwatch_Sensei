using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarPip : MonoBehaviour
{
    public Image image;

    public void SetToHealth()
    {
        image.color = HeroColors.Instance.healthColor;
    }
    public void SetToShield()
    {
        image.color = HeroColors.Instance.shieldColor;
    }
    public void SetToArmor()
    {
        image.color = HeroColors.Instance.armorColor;
    }
}
