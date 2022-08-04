using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroRight : MonoBehaviour
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
        if (nowShowing != Main.Instance.counterPick)
        {
            nowShowing = Main.Instance.counterPick;
            image.sprite = Resources.Load<Sprite>("Heroes/CareerPortrait/RightAligned/" + nowShowing);

            DebugOverlay.Output("Heroes/CareerPortrait/RightAligned/" + nowShowing);

            if (Main.Instance.counterPick != HERO_ID.None)
            {
                Show();
                int health = Main.Instance.heroes[(int)Main.Instance.counterPick].health;
                int armor = Main.Instance.heroes[(int)Main.Instance.counterPick].armor;
                int shields = Main.Instance.heroes[(int)Main.Instance.counterPick].shields;
                healthBar.SetValue(health, armor, shields);
            } else {
                Hide();
            }
        }
    }
}
