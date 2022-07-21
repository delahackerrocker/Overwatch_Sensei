using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeBG : MonoBehaviour
{
    public Image image;
    public Heroes nowShowing = Heroes.None;
    void Start()
    {
        image = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nowShowing != Main.Instance.selectedHero)
        {
            nowShowing = Main.Instance.selectedHero;
            image.color = HeroColors.Instance.GetHeroColor(nowShowing);
        }
        if (Main.Instance.counterPick == Heroes.None)
        {
            image.enabled = true;
        }
        else
        {
            image.enabled = false;
        }
    }
}
