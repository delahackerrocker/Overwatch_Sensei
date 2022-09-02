using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextHeroAbility : MonoBehaviour
{
    public void GoToNext()
    {
        Main.Instance.abilityIndex++;

        if (Main.Instance.abilityIndex >= Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities.Length)
        {
            Main.Instance.abilityIndex = 0;
        }

        Main.Instance.selectedAbility = Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[Main.Instance.abilityIndex];

        PanelNavigation.Instance.GOTO_HeroAbilityDetails();
    }
}
