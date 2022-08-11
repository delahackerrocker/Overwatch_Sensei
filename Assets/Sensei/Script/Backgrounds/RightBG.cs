using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RightBG : MonoBehaviour
{
    public Image image;
    public HERO_ID nowShowing = HERO_ID.None;
    void Start()
    {
        image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nowShowing != Main.Instance.counterPick)
        {
            nowShowing = Main.Instance.counterPick;
            //image.color = HeroColors.Instance.GetHeroColor(nowShowing);
            image.DOColor(HeroColors.Instance.GetHeroColor(nowShowing), 0.45f);
        }
    }
}