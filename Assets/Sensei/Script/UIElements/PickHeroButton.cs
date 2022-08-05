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

    private void Start()
    {
        UpdateImage(heroID);
    }
    public void UpdateImage(HERO_ID heroID)
    {
        this.heroID = heroID;
        image.sprite = Resources.Load<Sprite>("Heroes/Icons/" + heroID);
        title.text = ""+heroID;
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
