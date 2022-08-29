using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMatchups : MonoBehaviour
{
    // Singleton
    public static HeroMatchups Instance { get; private set; }
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

    public TextAsset[] GetHero(HERO_ID heroID)
    {
        if (heroID ==  HERO_ID.Ana)
        {
            return Ana();
        }
        else if (heroID == HERO_ID.Ashe)
        {
            return Ashe();
        }
        else if(heroID == HERO_ID.Baptiste)
        {
            return Baptiste();
        }
        else if(heroID == HERO_ID.Bastion)
        {
            return Bastion();
        }
        else if(heroID == HERO_ID.Brigitte)
        {
            return Brigitte();
        }
        else if(heroID == HERO_ID.Cassidy)
        {
            return Cassidy();
        }
        else if(heroID == HERO_ID.Doomfist)
        {
            return Doomfist();
        }
        else if(heroID == HERO_ID.DVa)
        {
            return DVa();
        }
        else if(heroID == HERO_ID.Echo)
        {
            return Echo();
        }
        else if(heroID == HERO_ID.Genji)
        {
            return Genji();
        }
        else if(heroID == HERO_ID.Hanzo)
        {
            return Hanzo();
        }
        else if(heroID == HERO_ID.Junkrat)
        {
            return Junkrat();
        }
        else if(heroID == HERO_ID.Lucio)
        {
            return Lucio();
        }
        else if(heroID == HERO_ID.Mei)
        {
            return Mei();
        }
        else if(heroID == HERO_ID.Mercy)
        {
            return Mercy();
        }
        else if(heroID == HERO_ID.Moira)
        {
            return Moira();
        }
        else if(heroID == HERO_ID.Orisa)
        {
            return Orisa();
        }
        else if(heroID == HERO_ID.Pharah)
        {
            return Pharah();
        }
        else if(heroID == HERO_ID.Reaper)
        {
            return Reaper();
        }
        else if(heroID == HERO_ID.Reinhardt)
        {
            return Reinhardt();
        }
        else if(heroID == HERO_ID.Roadhog)
        {
            return Roadhog();
        }
        else if(heroID == HERO_ID.Sigma)
        {
            return Sigma();
        }
        else if(heroID == HERO_ID.Soldier76)
        {
            return Soldier76();
        }
        else if(heroID == HERO_ID.Sombra)
        {
            return Sombra();
        }
        else if(heroID == HERO_ID.Symmetra)
        {
            return Symmetra();
        }
        else if(heroID == HERO_ID.Torbjorn)
        {
            return Torbjorn();
        }
        else if(heroID == HERO_ID.Tracer)
        {
            return Tracer();
        }
        else if(heroID == HERO_ID.Widowmaker)
        {
            return Widowmaker();
        }
        else if(heroID == HERO_ID.Winston)
        {
            return Winston();
        }
        else if(heroID == HERO_ID.WreckingBall)
        {
            return WreckingBall();
        }
        else if(heroID == HERO_ID.Zarya)
        {
            return Zarya();
        }
        else if(heroID == HERO_ID.Zenyatta)
        {
            return Zenyatta();
        } else
        {
            Debug.Log("!!! RETURNING NO MATCHUPS !!!");
            return noMatchups;
        }
    }

    public TextAsset[] anaMatchups;
    public TextAsset[] asheMatchups;
    public TextAsset[] baptisteMatchups;
    public TextAsset[] bastionMatchups;
    public TextAsset[] brigitteMatchups;
    public TextAsset[] cassidyMatchups;
    public TextAsset[] doomfistMatchups;
    public TextAsset[] dvaMatchups;
    public TextAsset[] echoMatchups;
    public TextAsset[] genjiMatchups;
    public TextAsset[] hanzoMatchups;
    public TextAsset[] junkratMatchups;
    public TextAsset[] lucioMatchups;
    public TextAsset[] meiMatchups;
    public TextAsset[] mercyMatchups;
    public TextAsset[] moiraMatchups;
    public TextAsset[] orisaMatchups;
    public TextAsset[] pharahMatchups;
    public TextAsset[] reaperMatchups;
    public TextAsset[] reinhardtMatchups;
    public TextAsset[] roadhogMatchups;
    public TextAsset[] sigmaMatchups;
    public TextAsset[] soldier76Matchups;
    public TextAsset[] sombraMatchups;
    public TextAsset[] symmetraMatchups;
    public TextAsset[] torbjornMatchups;
    public TextAsset[] tracerMatchups;
    public TextAsset[] widowmakerMatchups;
    public TextAsset[] winstonMatchups;
    public TextAsset[] wreckingballMatchups;
    public TextAsset[] zaryaMatchups;
    public TextAsset[] zenyattaMatchups;
    public TextAsset[] noMatchups;

    public TextAsset[] Ana() { return anaMatchups; }
    public TextAsset[] Ashe() { return asheMatchups; }
    public TextAsset[] Baptiste() { return baptisteMatchups; }
    public TextAsset[] Bastion() { return bastionMatchups; }
    public TextAsset[] Brigitte() { return brigitteMatchups; }
    public TextAsset[] Cassidy() { return cassidyMatchups; }
    public TextAsset[] Doomfist() { return doomfistMatchups; }
    public TextAsset[] DVa() { return dvaMatchups; }
    public TextAsset[] Echo() { return echoMatchups; }
    public TextAsset[] Genji() { return genjiMatchups; }
    public TextAsset[] Hanzo() { return hanzoMatchups; }
    public TextAsset[] Junkrat() { return junkratMatchups; }
    public TextAsset[] Lucio() { return lucioMatchups; }
    public TextAsset[] Mei() { return meiMatchups; }
    public TextAsset[] Mercy() { return mercyMatchups; }
    public TextAsset[] Moira() { return moiraMatchups; }
    public TextAsset[] Orisa() { return orisaMatchups; }
    public TextAsset[] Pharah() { return pharahMatchups; }
    public TextAsset[] Reaper() { return reaperMatchups; }
    public TextAsset[] Reinhardt() { return reinhardtMatchups; }
    public TextAsset[] Roadhog() { return roadhogMatchups; }
    public TextAsset[] Sigma() { return sigmaMatchups; }
    public TextAsset[] Soldier76() { return soldier76Matchups; }
    public TextAsset[] Sombra() { return sombraMatchups; }
    public TextAsset[] Symmetra() { return symmetraMatchups; }
    public TextAsset[] Torbjorn() { return torbjornMatchups; }
    public TextAsset[] Tracer() { return tracerMatchups; }
    public TextAsset[] Widowmaker() { return widowmakerMatchups; }
    public TextAsset[] Winston() { return winstonMatchups; }
    public TextAsset[] WreckingBall() { return wreckingballMatchups; }
    public TextAsset[] Zarya() { return zaryaMatchups; }
    public TextAsset[] Zenyatta() { return zenyattaMatchups; }
}