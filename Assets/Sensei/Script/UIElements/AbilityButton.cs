using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AbilityButton : MonoBehaviour
{
    public ControllerButton controllerButton;
    public AbilityData abilityData;

    public Button button;
    public TextMeshProUGUI buttonName;
    public TextMeshProUGUI abilityName;
    public Image icon;

    public void Select()
    {
        if (abilityData == null || Main.Instance.selectedHero == HERO_ID.None) return;
        Main.Instance.selectedAbility = abilityData;
        Main.Instance.abilityIndex = System.Array.IndexOf(
            Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities, abilityData);
        PanelNavigation.Instance.GOTO_HeroAbilityDetails();
    }

    public void UpdateButton(ControllerButton controllerButton,  AbilityData abilityData)
    {
        this.controllerButton = controllerButton;
        this.abilityData = abilityData;

        abilityName.text = abilityData.abilityName;
        this.icon.gameObject.SetActive(true);
        this.icon.sprite = Resources.Load<Sprite>(abilityData.abilityIcon);
        button.interactable = true;
    }

    public void ClearButton()
    {
        abilityName.text = "";
        icon.gameObject.SetActive(false);
        button.interactable = false;
    }

}
