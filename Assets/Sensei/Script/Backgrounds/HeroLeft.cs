using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroLeft : MonoBehaviour
{
    public Image image;
    public HERO_ID nowShowing = HERO_ID.None;

    public HealthBar healthBar;

    public CanvasGroup canvasGroup;

    public void Hide()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
    }
    public void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
    }

    void Start()
    {
        image = this.GetComponent<Image>();
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        if (nowShowing != Main.Instance.selectedHero)
        {
            nowShowing = Main.Instance.selectedHero;
            image.sprite = Resources.Load<Sprite>("Heroes/CareerPortrait/LeftAligned/"+ nowShowing);

            DebugOverlay.Output("Heroes/CareerPortrait/LeftAligned/" + nowShowing);

            if (Main.Instance.selectedHero != HERO_ID.None)
            {
                Show();
                int health = Main.Instance.heroes[(int)Main.Instance.selectedHero].health;
                int armor = Main.Instance.heroes[(int)Main.Instance.selectedHero].armor;
                int shields = Main.Instance.heroes[(int)Main.Instance.selectedHero].shields;
                healthBar.SetValue(health, armor, shields);
            } else {
                Hide();
            }
        }
    }
}
