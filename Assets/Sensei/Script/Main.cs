using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Singleton
    public static Main Instance { get; private set; }
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

    public HERO_ID selectedHero = HERO_ID.None;
    public HERO_ID counterPick = HERO_ID.None;

    public AbilityData selectedAbility = null;
    public int abilityIndex = 0;

    public HeroData[] heroes = new HeroData[32];

    private void Start()
    {
        InitializeAllHeroData();
    }

    void InitializeAllHeroData()
    {
        heroes[(int)HERO_ID.Ana] = new AnaHD();
        heroes[(int)HERO_ID.Ashe] = new AsheHD();
        heroes[(int)HERO_ID.Baptiste] = new BaptisteHD();
        heroes[(int)HERO_ID.Bastion] = new BastionHD();
        heroes[(int)HERO_ID.Brigitte] = new BrigitteHD();
        heroes[(int)HERO_ID.Cassidy] = new CassidyHD();
        heroes[(int)HERO_ID.Doomfist] = new DVaHD();
        heroes[(int)HERO_ID.DVa] = new DoomfistHD();
        heroes[(int)HERO_ID.Echo] = new EchoHD();
        heroes[(int)HERO_ID.Genji] = new GenjiHD();
        heroes[(int)HERO_ID.Hanzo] = new HanzoHD();
        heroes[(int)HERO_ID.Junkrat] = new JunkratHD();
        heroes[(int)HERO_ID.Lucio] = new LucioHD();
        heroes[(int)HERO_ID.Mei] = new MeiHD();
        heroes[(int)HERO_ID.Mercy] = new MercyHD();
        heroes[(int)HERO_ID.Moira] = new MoiraHD();
        heroes[(int)HERO_ID.Orisa] = new OrisaHD();
        heroes[(int)HERO_ID.Pharah] = new PharahHD();
        heroes[(int)HERO_ID.Reaper] = new ReaperHD();
        heroes[(int)HERO_ID.Reinhardt] = new ReinhardtHD();
        heroes[(int)HERO_ID.Roadhog] = new RoadhogHD();
        heroes[(int)HERO_ID.Sigma] = new SigmaHD();
        heroes[(int)HERO_ID.Soldier76] = new Soldier76HD();
        heroes[(int)HERO_ID.Sombra] = new SombraHD();
        heroes[(int)HERO_ID.Symmetra] = new SymmetraHD();
        heroes[(int)HERO_ID.Torbjorn] = new TorbjornHD();
        heroes[(int)HERO_ID.Tracer] = new TracerHD();
        heroes[(int)HERO_ID.Widowmaker] = new WidowmakerHD();
        heroes[(int)HERO_ID.Winston] = new WinstonHD();
        heroes[(int)HERO_ID.WreckingBall] = new WreckingBallHD();
        heroes[(int)HERO_ID.Zarya] = new ZaryaHD();
        heroes[(int)HERO_ID.Zenyatta] = new ZenyattaHD();
    }
}