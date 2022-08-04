using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftBG : MonoBehaviour
{
    public Image image;
    public HERO_ID nowShowing = HERO_ID.None;
    void Start()
    {
        image = this.GetComponent<Image>();
    }

    void Update()
    {
        if (nowShowing != Main.Instance.selectedHero)
        {
            nowShowing = Main.Instance.selectedHero;
            image.color = HeroColors.Instance.GetHeroColor(nowShowing);
        }
    }
}