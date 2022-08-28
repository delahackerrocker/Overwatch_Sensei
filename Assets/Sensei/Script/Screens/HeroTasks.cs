using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroTasks : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI fullSummary;

    public HERO_ID nowShowing = HERO_ID.None;

    private void Update()
    {
        if ((nowShowing != Main.Instance.selectedHero) && (Main.Instance.selectedHero != HERO_ID.None))
        {
            nowShowing = Main.Instance.selectedHero;

            title.text = Main.Instance.selectedHero + "";

            fullSummary.text = HeroSummaries.Instance.textAssets[(int)nowShowing].text;
        }
    }
}