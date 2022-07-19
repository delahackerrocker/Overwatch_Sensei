using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroColors : MonoBehaviour
{
    public static HeroColors Instance { get; private set; }

    public Color32 AnaColor;
    public Color32 AsheColor;
    public Color32 BaptisteColor;
    public Color32 BastionColor;
    public Color32 BrigittaColor;
    public Color32 CassidyColor;
    public Color32 DVaColor;
    public Color32 DoomfistColor;
    public Color32 EchoColor;
    public Color32 GenjiColor;
    public Color32 HanzoColor;
    public Color32 JunkratColor;
    public Color32 LucioColor;
    public Color32 MeiColor;
    public Color32 MercyColor;
    public Color32 MoiraColor;
    public Color32 OrisaColor;
    public Color32 PharahColor;
    public Color32 ReaperColor;
    public Color32 ReinhardtColor;
    public Color32 RoadhogColor;
    public Color32 SigmaColor;
    public Color32 Soldier76Color;
    public Color32 SombraColor;
    public Color32 SymmetraColor;
    public Color32 TorbjornColor;
    public Color32 TracerColor;
    public Color32 WidowmakerColor;
    public Color32 WinstonColor;
    public Color32 WreckingBallColor;
    public Color32 ZaryaColor;
    public Color32 ZenyattaColor;


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

    public Color32 GetHeroColor(Heroes hero)
    {
        DebugOverlay.Output("Hero GetHeroColor: " + hero);
        Main.Instance.selectedHero = hero;
        Color32 returnColor = AnaColor;
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

            case Heroes.Soldier:
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
        return AnaColor;
    }

    public Color32 Ana() { return GetHeroColor(Heroes.Ana); }
    public Color32 Ashe() { return GetHeroColor(Heroes.Ashe); }
    public Color32 Baptiste() { return GetHeroColor(Heroes.Baptiste); }
    public Color32 Bastion() { return GetHeroColor(Heroes.Bastion); }
    public Color32 Brigitte() { return GetHeroColor(Heroes.Brigitte); }
    public Color32 Cassidy() { return GetHeroColor(Heroes.Cassidy); }
    public Color32 Doomfist() { return GetHeroColor(Heroes.Doomfist); }
    public Color32 DVa() { return GetHeroColor(Heroes.DVa); }
    public Color32 Echo() { return GetHeroColor(Heroes.Echo); }
    public Color32 Genji() { return GetHeroColor(Heroes.Genji); }
    public Color32 Hanzo() { return GetHeroColor(Heroes.Hanzo); }
    public Color32 Junkrat() { return GetHeroColor(Heroes.Junkrat); }
    public Color32 Lucio() { return GetHeroColor(Heroes.Lucio); }
    public Color32 Mei() { return GetHeroColor(Heroes.Mei); }
    public Color32 Mercy() { return GetHeroColor(Heroes.Mercy); }
    public Color32 Moira() { return GetHeroColor(Heroes.Moira); }
    public Color32 Orisa() { return GetHeroColor(Heroes.Orisa); }
    public Color32 Pharah() { return GetHeroColor(Heroes.Pharah); }
    public Color32 Reaper() { return GetHeroColor(Heroes.Reaper); }
    public Color32 Reinhardt() { return GetHeroColor(Heroes.Reinhardt); }
    public Color32 Roadhog() { return GetHeroColor(Heroes.Roadhog); }
    public Color32 Sigma() { return GetHeroColor(Heroes.Sigma); }
    public Color32 Soldier76() { return GetHeroColor(Heroes.Soldier); }
    public Color32 Sombra() { return GetHeroColor(Heroes.Sombra); }
    public Color32 Symmetra() { return GetHeroColor(Heroes.Symmetra); }
    public Color32 Torbjorn() { return GetHeroColor(Heroes.Torbjorn); }
    public Color32 Tracer() { return GetHeroColor(Heroes.Tracer); }
    public Color32 Widowmaker() { return GetHeroColor(Heroes.Widowmaker); }
    public Color32 Winston() { return GetHeroColor(Heroes.Winston); }
    public Color32 WreckingBall() { return GetHeroColor(Heroes.WreckingBall); }
    public Color32 Zarya() { return GetHeroColor(Heroes.Zarya); }
    public Color32 Zenyatta() { return GetHeroColor(Heroes.Zenyatta); }
}