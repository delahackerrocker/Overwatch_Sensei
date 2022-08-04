using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public TextMeshProUGUI healthTotal;
    public GameObject[] pips;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetValue(int health, int armor, int shield)
    {
        int healthPips = health / 25;
        Debug.Log("healthPips: " + healthPips);
        int armorPips = armor / 25;
        Debug.Log("armorPips: " + armorPips);
        int shieldPips = shield / 25;
        Debug.Log("shieldPips: " + shieldPips);

        for (int count = 0; count < pips.Length; count++)
        {
            if (healthPips > count)
            {
                pips[count].SetActive(true);
                pips[count].GetComponent<HealthBarPip>().SetToHealth();
            } else if ((healthPips+armorPips) > count)
            {
                pips[count].SetActive(true);
                pips[count].GetComponent<HealthBarPip>().SetToArmor();
            }
            else if ((healthPips + shieldPips) > count)
            {
                pips[count].SetActive(true);
                pips[count].GetComponent<HealthBarPip>().SetToShield();
            }
            else
            {
                pips[count].SetActive(false);
            }
        }
        int combinedHealth = (health + armor + shield);
        healthTotal.text = combinedHealth + " / " + combinedHealth;
    }
}