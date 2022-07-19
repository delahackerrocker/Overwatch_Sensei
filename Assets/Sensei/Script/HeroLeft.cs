using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class HeroLeft : MonoBehaviour
{
    public Image image;
    public Heroes nowShowing = Heroes.Ashe;
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
            this.GetComponent<Image>().sprite = Resources.Load<Sprite>("Heroes/CareerPortrait/LeftAligned/"+ nowShowing);

            DebugOverlay.Output("Heroes/CareerPortrait/LeftAligned/" + nowShowing);
        }
    }
}
