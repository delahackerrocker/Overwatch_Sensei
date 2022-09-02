using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroColors : MonoBehaviour
{
    // Singleton
    public static HeroColors Instance { get; private set; }
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

    public Color AnaColor;
    public Color AsheColor;
    public Color BaptisteColor;
    public Color BastionColor;
    public Color BrigittaColor;
    public Color CassidyColor;
    public Color DVaColor;
    public Color DoomfistColor;
    public Color EchoColor;
    public Color GenjiColor;
    public Color HanzoColor;
    public Color JunkratColor;
    public Color LucioColor;
    public Color MeiColor;
    public Color MercyColor;
    public Color MoiraColor;
    public Color OrisaColor;
    public Color PharahColor;
    public Color ReaperColor;
    public Color ReinhardtColor;
    public Color RoadhogColor;
    public Color SigmaColor;
    public Color Soldier76Color;
    public Color SombraColor;
    public Color SymmetraColor;
    public Color TorbjornColor;
    public Color TracerColor;
    public Color WidowmakerColor;
    public Color WinstonColor;
    public Color WreckingBallColor;
    public Color ZaryaColor;
    public Color ZenyattaColor;
    public Color None;

    public Color healthColor = Color.white;
    public Color shieldColor;
    public Color armorColor;

    public Color alphaBlack;

    public Color GetHeroColor(HERO_ID hero)
    {
        DebugOverlay.Output("Hero GetHeroColor: " + hero);
        Color returnColor = None;
        switch (hero)
        {
            case HERO_ID.Ana:
                returnColor = AnaColor;
                break;

            case HERO_ID.Ashe:
                returnColor = AsheColor;
                break;

            case HERO_ID.Baptiste:
                returnColor = BaptisteColor;
                break;

            case HERO_ID.Bastion:
                returnColor = BastionColor;
                break;

            case HERO_ID.Brigitte:
                returnColor = BrigittaColor;
                break;

            case HERO_ID.Cassidy:
                returnColor = CassidyColor;
                break;

            case HERO_ID.DVa:
                returnColor = DVaColor;
                break;

            case HERO_ID.Doomfist:
                returnColor = DoomfistColor;
                break;

            case HERO_ID.Echo:
                returnColor = EchoColor;
                break;

            case HERO_ID.Genji:
                returnColor = GenjiColor;
                break;

            case HERO_ID.Hanzo:
                returnColor = HanzoColor;
                break;

            case HERO_ID.Junkrat:
                returnColor = JunkratColor;
                break;

            case HERO_ID.Lucio:
                returnColor = LucioColor;
                break;

            case HERO_ID.Mei:
                returnColor = MeiColor;
                break;

            case HERO_ID.Mercy:
                returnColor = MercyColor;
                break;

            case HERO_ID.Moira:
                returnColor = MoiraColor;
                break;

            case HERO_ID.Orisa:
                returnColor = OrisaColor;
                break;

            case HERO_ID.Pharah:
                returnColor = PharahColor;
                break;

            case HERO_ID.Reaper:
                returnColor = ReaperColor;
                break;

            case HERO_ID.Reinhardt:
                returnColor = ReinhardtColor;
                break;

            case HERO_ID.Roadhog:
                returnColor = RoadhogColor;
                break;

            case HERO_ID.Sigma:
                returnColor = SigmaColor;
                break;

            case HERO_ID.Soldier76:
                returnColor = Soldier76Color;
                break;

            case HERO_ID.Sombra:
                returnColor = SombraColor;
                break;

            case HERO_ID.Symmetra:
                returnColor = SymmetraColor;
                break;

            case HERO_ID.Torbjorn:
                returnColor = TorbjornColor;
                break;

            case HERO_ID.Tracer:
                returnColor = TracerColor;
                break;

            case HERO_ID.Widowmaker:
                returnColor = WidowmakerColor;
                break;

            case HERO_ID.Winston:
                returnColor = WinstonColor;
                break;

            case HERO_ID.WreckingBall:
                returnColor = WreckingBallColor;
                break;

            case HERO_ID.Zarya:
                returnColor = ZaryaColor;
                break;

            case HERO_ID.Zenyatta:
                returnColor = ZenyattaColor;
                break;
        }
        return returnColor;
    }

    public Color Ana() { return GetHeroColor(HERO_ID.Ana); }
    public Color Ashe() { return GetHeroColor(HERO_ID.Ashe); }
    public Color Baptiste() { return GetHeroColor(HERO_ID.Baptiste); }
    public Color Bastion() { return GetHeroColor(HERO_ID.Bastion); }
    public Color Brigitte() { return GetHeroColor(HERO_ID.Brigitte); }
    public Color Cassidy() { return GetHeroColor(HERO_ID.Cassidy); }
    public Color Doomfist() { return GetHeroColor(HERO_ID.Doomfist); }
    public Color DVa() { return GetHeroColor(HERO_ID.DVa); }
    public Color Echo() { return GetHeroColor(HERO_ID.Echo); }
    public Color Genji() { return GetHeroColor(HERO_ID.Genji); }
    public Color Hanzo() { return GetHeroColor(HERO_ID.Hanzo); }
    public Color Junkrat() { return GetHeroColor(HERO_ID.Junkrat); }
    public Color Lucio() { return GetHeroColor(HERO_ID.Lucio); }
    public Color Mei() { return GetHeroColor(HERO_ID.Mei); }
    public Color Mercy() { return GetHeroColor(HERO_ID.Mercy); }
    public Color Moira() { return GetHeroColor(HERO_ID.Moira); }
    public Color Orisa() { return GetHeroColor(HERO_ID.Orisa); }
    public Color Pharah() { return GetHeroColor(HERO_ID.Pharah); }
    public Color Reaper() { return GetHeroColor(HERO_ID.Reaper); }
    public Color Reinhardt() { return GetHeroColor(HERO_ID.Reinhardt); }
    public Color Roadhog() { return GetHeroColor(HERO_ID.Roadhog); }
    public Color Sigma() { return GetHeroColor(HERO_ID.Sigma); }
    public Color Soldier76() { return GetHeroColor(HERO_ID.Soldier76); }
    public Color Sombra() { return GetHeroColor(HERO_ID.Sombra); }
    public Color Symmetra() { return GetHeroColor(HERO_ID.Symmetra); }
    public Color Torbjorn() { return GetHeroColor(HERO_ID.Torbjorn); }
    public Color Tracer() { return GetHeroColor(HERO_ID.Tracer); }
    public Color Widowmaker() { return GetHeroColor(HERO_ID.Widowmaker); }
    public Color Winston() { return GetHeroColor(HERO_ID.Winston); }
    public Color WreckingBall() { return GetHeroColor(HERO_ID.WreckingBall); }
    public Color Zarya() { return GetHeroColor(HERO_ID.Zarya); }
    public Color Zenyatta() { return GetHeroColor(HERO_ID.Zenyatta); }
}