using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroKit : MonoBehaviour
{
    public TextMeshProUGUI title;

    public AbilityButton leftTriggerBTN;
    public AbilityButton leftBumperBTN;
    public AbilityButton rightBumperBTN;
    public AbilityButton rightTriggerBTN;
    public AbilityButton ABTN;
    public AbilityButton BBTN;
    public AbilityButton XBTN;
    public AbilityButton YBTN;

    public HERO_ID nowShowing = HERO_ID.None;

    private void Update()
    {
        title.text = Main.Instance.selectedHero + "'S KIT";

        if ((nowShowing != Main.Instance.selectedHero) && (Main.Instance.selectedHero != HERO_ID.None))
        {
            nowShowing = Main.Instance.selectedHero;

            int abilityCount = Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities.Length;

            int index = 0;
            // check to see if there is a left trigger ability
            for (index = 0; index < abilityCount; index++)
            {
                Debug.Log("Main.Instance.selectedHero: " + Main.Instance.selectedHero);
                Debug.Log("HERO_ID.Pharah: " + HERO_ID.Pharah);
                Debug.Log("index: " + index);
                Debug.Log("Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]: " + Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.LeftTrigger)
                {
                    leftTriggerBTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount-1)
                {// No ability for this button exists
                    leftTriggerBTN.ClearButton();
                }
            }

            // check to see if there is a left bumper ability
            for (index = 0; index < abilityCount; index++)
            {
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.LeftBumper)
                {
                    leftBumperBTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount - 1)
                {// No ability for this button exists
                    leftBumperBTN.ClearButton();
                }
            }

            // check to see if there is a right bumper ability
            for (index = 0; index < abilityCount; index++)
            {
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.RightBumper)
                {
                    rightBumperBTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount - 1)
                {// No ability for this button exists
                    rightBumperBTN.ClearButton();
                }
            }

            // check to see if there is a right trigger ability
            for (index = 0; index < abilityCount; index++)
            {
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.RightTrigger)
                {
                    rightTriggerBTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount - 1)
                {// No ability for this button exists
                    rightTriggerBTN.ClearButton();
                }
            }

            // check to see if there is an A button ability
            for (index = 0; index < abilityCount; index++)
            {
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.A)
                {
                    ABTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount - 1)
                {// No ability for this button exists
                    ABTN.ClearButton();
                }
            }

            // check to see if there is a B button ability
            for (index = 0; index < abilityCount; index++)
            {
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.B)
                {
                    BBTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount - 1)
                {// No ability for this button exists
                    BBTN.ClearButton();
                }
            }

            // check to see if there is a X button ability
            for (index = 0; index < abilityCount; index++)
            {
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.X)
                {
                    XBTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount - 1)
                {// No ability for this button exists
                    XBTN.ClearButton();
                }
            }

            // check to see if there is a Y button ability
            for (index = 0; index < abilityCount; index++)
            {
                if (Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton == ControllerButton.Y)
                {
                    YBTN.UpdateButton(Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index].controllerButton, Main.Instance.heroes[(int)Main.Instance.selectedHero].abilities[index]);
                    break;
                }
                if (index == abilityCount - 1)
                {// No ability for this button exists
                    YBTN.ClearButton();
                }
            }
        } else
        {
            Main.Instance.selectedAbility = null;
        }

    }
}