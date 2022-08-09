using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroAbilityDetails : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI buttonName;
    public TextMeshProUGUI abilityDetail;

    private void Update()
    {
        if ((Main.Instance.selectedHero != HERO_ID.None) && (Main.Instance.selectedAbility != null))
        {
            title.text = Main.Instance.selectedHero + ": "+ Main.Instance.selectedAbility.abilityName;
            buttonName.text = ""+Main.Instance.selectedAbility.controllerButton;
            abilityDetail.text = "" + Main.Instance.selectedAbility.abilityDetail;
        }
    }
}