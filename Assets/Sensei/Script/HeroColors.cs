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

    public Color GetHeroColor(Heroes hero)
    {
        DebugOverlay.Output("Hero GetHeroColor: " + hero);
        Color returnColor = None;
        switch (hero)
        {
            case Heroes.Ana:
                returnColor = AnaColor;
                break;

            case Heroes.Ashe:
                returnColor = AsheColor;
                break;

            case Heroes.Baptiste:
                returnColor = BaptisteColor;
                break;

            case Heroes.Bastion:
                returnColor = BastionColor;
                break;

            case Heroes.Brigitte:
                returnColor = BrigittaColor;
                break;

            case Heroes.Cassidy:
                returnColor = CassidyColor;
                break;

            case Heroes.DVa:
                returnColor = DVaColor;
                break;

            case Heroes.Doomfist:
                returnColor = DoomfistColor;
                break;

            case Heroes.Echo:
                returnColor = EchoColor;
                break;

            case Heroes.Genji:
                returnColor = GenjiColor;
                break;

            case Heroes.Hanzo:
                returnColor = HanzoColor;
                break;

            case Heroes.Junkrat:
                returnColor = JunkratColor;
                break;

            case Heroes.Lucio:
                returnColor = LucioColor;
                break;

            case Heroes.Mei:
                returnColor = MeiColor;
                break;

            case Heroes.Mercy:
                returnColor = MercyColor;
                break;

            case Heroes.Moira:
                returnColor = MoiraColor;
                break;

            case Heroes.Orisa:
                returnColor = OrisaColor;
                break;

            case Heroes.Pharah:
                returnColor = PharahColor;
                break;

            case Heroes.Reaper:
                returnColor = ReaperColor;
                break;

            case Heroes.Reinhardt:
                returnColor = ReinhardtColor;
                break;

            case Heroes.Roadhog:
                returnColor = RoadhogColor;
                break;

            case Heroes.Sigma:
                returnColor = SigmaColor;
                break;

            case Heroes.Soldier76:
                returnColor = Soldier76Color;
                break;

            case Heroes.Sombra:
                returnColor = SombraColor;
                break;

            case Heroes.Symmetra:
                returnColor = SymmetraColor;
                break;

            case Heroes.Torbjorn:
                returnColor = TorbjornColor;
                break;

            case Heroes.Tracer:
                returnColor = TracerColor;
                break;

            case Heroes.Widowmaker:
                returnColor = WidowmakerColor;
                break;

            case Heroes.Winston:
                returnColor = WinstonColor;
                break;

            case Heroes.WreckingBall:
                returnColor = WreckingBallColor;
                break;

            case Heroes.Zarya:
                returnColor = ZaryaColor;
                break;

            case Heroes.Zenyatta:
                returnColor = ZenyattaColor;
                break;
        }
        return returnColor;
    }

    public Color Ana() { return GetHeroColor(Heroes.Ana); }
    public Color Ashe() { return GetHeroColor(Heroes.Ashe); }
    public Color Baptiste() { return GetHeroColor(Heroes.Baptiste); }
    public Color Bastion() { return GetHeroColor(Heroes.Bastion); }
    public Color Brigitte() { return GetHeroColor(Heroes.Brigitte); }
    public Color Cassidy() { return GetHeroColor(Heroes.Cassidy); }
    public Color Doomfist() { return GetHeroColor(Heroes.Doomfist); }
    public Color DVa() { return GetHeroColor(Heroes.DVa); }
    public Color Echo() { return GetHeroColor(Heroes.Echo); }
    public Color Genji() { return GetHeroColor(Heroes.Genji); }
    public Color Hanzo() { return GetHeroColor(Heroes.Hanzo); }
    public Color Junkrat() { return GetHeroColor(Heroes.Junkrat); }
    public Color Lucio() { return GetHeroColor(Heroes.Lucio); }
    public Color Mei() { return GetHeroColor(Heroes.Mei); }
    public Color Mercy() { return GetHeroColor(Heroes.Mercy); }
    public Color Moira() { return GetHeroColor(Heroes.Moira); }
    public Color Orisa() { return GetHeroColor(Heroes.Orisa); }
    public Color Pharah() { return GetHeroColor(Heroes.Pharah); }
    public Color Reaper() { return GetHeroColor(Heroes.Reaper); }
    public Color Reinhardt() { return GetHeroColor(Heroes.Reinhardt); }
    public Color Roadhog() { return GetHeroColor(Heroes.Roadhog); }
    public Color Sigma() { return GetHeroColor(Heroes.Sigma); }
    public Color Soldier76() { return GetHeroColor(Heroes.Soldier76); }
    public Color Sombra() { return GetHeroColor(Heroes.Sombra); }
    public Color Symmetra() { return GetHeroColor(Heroes.Symmetra); }
    public Color Torbjorn() { return GetHeroColor(Heroes.Torbjorn); }
    public Color Tracer() { return GetHeroColor(Heroes.Tracer); }
    public Color Widowmaker() { return GetHeroColor(Heroes.Widowmaker); }
    public Color Winston() { return GetHeroColor(Heroes.Winston); }
    public Color WreckingBall() { return GetHeroColor(Heroes.WreckingBall); }
    public Color Zarya() { return GetHeroColor(Heroes.Zarya); }
    public Color Zenyatta() { return GetHeroColor(Heroes.Zenyatta); }
}