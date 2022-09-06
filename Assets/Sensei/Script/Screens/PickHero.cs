using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HERO_ID
{
    Ana,
    Ashe,
    Baptiste,
    Bastion,
    Brigitte,
    Cassidy,
    Doomfist,
    DVa,
    Echo,
    Genji,
    Hanzo,
    Junkrat,
    Lucio,
    Mei,
    Mercy,
    Moira,
    Orisa,
    Pharah,
    Reaper,
    Reinhardt,
    Roadhog,
    Sigma,
    Soldier76,
    Sombra,
    Symmetra,
    Torbjorn,
    Tracer,
    Widowmaker,
    Winston,
    WreckingBall,
    Zarya,
    Zenyatta,
    None
}

public class PickHero : MonoBehaviour
{
    public void Picked(HERO_ID hero)
    {
        DebugOverlay.Output("Hero Picked: "+ hero);
        Main.Instance.selectedHero = hero;
        Main.Instance.counterPick = HERO_ID.None;
        PanelNavigation.Instance.GOTO_HeroTasks();
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