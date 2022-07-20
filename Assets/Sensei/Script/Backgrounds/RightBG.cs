using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightBG : MonoBehaviour
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
        if (nowShowing != Main.Instance.counterPick)
        {
            nowShowing = Main.Instance.counterPick;
            image.color = HeroColors.Instance.GetHeroColor(nowShowing);
        }
    }
}