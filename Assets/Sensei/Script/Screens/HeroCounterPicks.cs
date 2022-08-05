using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroCounterPicks : MonoBehaviour
{
    // Singleton
    public static HeroCounterPicks Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // ----

    public TextMeshProUGUI title;

    public PickHeroButton[] strongAgainst = new PickHeroButton[8];
    public PickHeroButton[] weakAgainst = new PickHeroButton[8];

    private void Update()
    {
        title.text = Main.Instance.selectedHero+": Counter Picks";
    }

    public void Picked(HERO_ID hero)
    {
        DebugOverlay.Output("Counter Picked: " + hero);
        Main.Instance.counterPick = hero;
        PanelNavigation.Instance.GOTO_HeroVersusHero();
    }

    public void Ana() { Picked(HERO_ID.Ana); }
    public void Ashe() { Picked(HERO_ID.Ashe); }
    public void Baptiste() { Picked(HERO_ID.Baptiste); }
    public void Bastion() { Picked(HERO_ID.Bastion); }
    public void Brigitte() { Picked(HERO_ID.Brigitte); }
    public void Cassidy() { Picked(HERO_ID.Cassidy); }
    public void Doomfist() { Picked(HERO_ID.Doomfist); }
    public void DVa() { Picked(HERO_ID.DVa); }
    public void Echo() { Picked(HERO_ID.Echo); }
    public void Genji() { Picked(HERO_ID.Genji); }
    public void Hanzo() { Picked(HERO_ID.Hanzo); }
    public void Junkrat() { Picked(HERO_ID.Junkrat); }
    public void Lucio() { Picked(HERO_ID.Lucio); }
    public void Mei() { Picked(HERO_ID.Mei); }
    public void Mercy() { Picked(HERO_ID.Mercy); }
    public void Moira() { Picked(HERO_ID.Moira); }
    public void Orisa() { Picked(HERO_ID.Orisa); }
    public void Pharah() { Picked(HERO_ID.Pharah); }
    public void Reaper() { Picked(HERO_ID.Reaper); }
    public void Reinhardt() { Picked(HERO_ID.Reinhardt); }
    public void Roadhog() { Picked(HERO_ID.Roadhog); }
    public void Sigma() { Picked(HERO_ID.Sigma); }
    public void Soldier76() { Picked(HERO_ID.Soldier76); }
    public void Sombra() { Picked(HERO_ID.Sombra); }
    public void Symmetra() { Picked(HERO_ID.Symmetra); }
    public void Torbjorn() { Picked(HERO_ID.Torbjorn); }
    public void Tracer() { Picked(HERO_ID.Tracer); }
    public void Widowmaker() { Picked(HERO_ID.Widowmaker); }
    public void Winston() { Picked(HERO_ID.Winston); }
    public void WreckingBall() { Picked(HERO_ID.WreckingBall); }
    public void Zarya() { Picked(HERO_ID.Zarya); }
    public void Zenyatta() { Picked(HERO_ID.Zenyatta); }
}