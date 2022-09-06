using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickHeroButton : MonoBehaviour
{
    public HERO_ID heroID;
    public Image image;
    public TextMeshProUGUI title;
    public Button button;

    private void Start()
    {
        button = this.gameObject.GetComponent<Button>();
        //UpdateImage(heroID);
    }
    public void UpdateImage(HERO_ID heroID)
    {
        this.heroID = heroID;

        Debug.Log("PickHeroButton.UpdateImage( "+ heroID + " )");

        if (heroID == HERO_ID.None)
        {
            button.enabled = false;
            image.gameObject.SetActive(false);
            title.text = "";
        } else
        {
            button.enabled = true;
            image.gameObject.SetActive(true);
            image.sprite = Resources.Load<Sprite>("Heroes/Icons/" + heroID);
            title.text = "" + heroID;
        }
    }

    public void SelectThisHero()
    {
        //HeroCounterPicks.Instance.Picked(heroID);
    }
    public void SelectThisOpponent()
    {
        HeroCounterPicks.Instance.Picked(heroID);
    }
}
