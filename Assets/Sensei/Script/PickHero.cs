using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Heroes
{
    Ana,
    Ashe,
    Baptiste,
    Bastion,
    Brigitte,
    Cassidy,
    DVa,
    Doomfist,
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
    Soldier,
    Sombra,
    Symmetra,
    Torbjorn,
    Tracer,
    Widowmaker,
    Winston,
    WreckingBall,
    Zarya,
    Zenyatta
}

public class PickHero : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Picked(Heroes hero)
    {
        DebugOverlay.Output("Hero Picked: "+ hero);
        Main.Instance.selectedHero = hero;
    }

    public void Ana() { Picked(Heroes.Ana); }
    public void Ashe() { Picked(Heroes.Ashe); }
    public void Baptiste() { Picked(Heroes.Baptiste); }
    public void Bastion() { Picked(Heroes.Bastion); }
    public void Brigitte() { Picked(Heroes.Brigitte); }
    public void Cassidy() { Picked(Heroes.Cassidy); }
    public void Doomfist() { Picked(Heroes.Doomfist); }
    public void DVa() { Picked(Heroes.DVa); }
    public void Echo() { Picked(Heroes.Echo); }
    public void Genji() { Picked(Heroes.Genji); }
    public void Hanzo() { Picked(Heroes.Hanzo); }
    public void Junkrat() { Picked(Heroes.Junkrat); }
    public void Lucio() { Picked(Heroes.Lucio); }
    public void Mei() { Picked(Heroes.Mei); }
    public void Mercy() { Picked(Heroes.Mercy); }
    public void Moira() { Picked(Heroes.Moira); }
    public void Orisa() { Picked(Heroes.Orisa); }
    public void Pharah() { Picked(Heroes.Pharah); }
    public void Reaper() { Picked(Heroes.Reaper); }
    public void Reinhardt() { Picked(Heroes.Reinhardt); }
    public void Roadhog() { Picked(Heroes.Roadhog); }
    public void Sigma() { Picked(Heroes.Sigma); }
    public void Soldier76() { Picked(Heroes.Soldier); }
    public void Sombra() { Picked(Heroes.Sombra); }
    public void Symmetra() { Picked(Heroes.Symmetra); }
    public void Torbjorn() { Picked(Heroes.Torbjorn); }
    public void Tracer() { Picked(Heroes.Tracer); }
    public void Widowmaker() { Picked(Heroes.Widowmaker); }
    public void Winston() { Picked(Heroes.Winston); }
    public void WreckingBall() { Picked(Heroes.WreckingBall); }
    public void Zarya() { Picked(Heroes.Zarya); }
    public void Zenyatta() { Picked(Heroes.Zenyatta); }
}