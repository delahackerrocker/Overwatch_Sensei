using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum Opponent
{
    Previous,
    Selected,
    Next
}

public class HeroVersusHero : MonoBehaviour
{
    public Opponent opponent;

    public TextMeshProUGUI title;
    public TextMeshProUGUI matchup;

    public HERO_ID nowShowing = HERO_ID.None;

    public void GoToHero()
    {
        if (opponent == Opponent.Previous)
        {
            if (Main.Instance.counterPick == HERO_ID.Ana)
            {
                Main.Instance.counterPick = HERO_ID.Zenyatta;
            } 
            else 
            {
                Main.Instance.counterPick = Main.Instance.counterPick - 1;
            }
            PanelNavigation.Instance.GOTO_HeroVersusHero();

        } else if (opponent == Opponent.Next)
        {
            if (Main.Instance.counterPick == HERO_ID.Zenyatta)
            {
                Main.Instance.counterPick = HERO_ID.Ana;
            }
            else
            {
                Main.Instance.counterPick = Main.Instance.counterPick + 1;
            }
            PanelNavigation.Instance.GOTO_HeroVersusHero();
        }
    }

    private void Update()
    {

        title.text = Main.Instance.selectedHero + " VS " + Main.Instance.counterPick;
        if (opponent == Opponent.Selected)
        {
            if ((Main.Instance.selectedHero != HERO_ID.None) && (Main.Instance.counterPick != HERO_ID.None))
            {
                nowShowing = Main.Instance.selectedHero;

                matchup.text = (string)HeroMatchups.Instance.GetHero(Main.Instance.selectedHero)[(int)Main.Instance.counterPick].text;
                //Debug.Log(HeroMatchups.Instance.GetHero(Main.Instance.selectedHero)[(int)Main.Instance.counterPick].text);
            }
        }
    }
}