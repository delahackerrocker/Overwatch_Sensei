using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

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
            //image.color = HeroColors.Instance.GetHeroColor(nowShowing);
            image.DOColor(HeroColors.Instance.GetHeroColor(nowShowing), 0.45f);
        }
    }
}