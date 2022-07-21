using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroAbilityDetails : MonoBehaviour
{
    public TextMeshProUGUI title;

    private void Update()
    {
        title.text = Main.Instance.selectedHero + ": Ability Name";
    }
}