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
        /*
        heroes[(int)18] = new ReaperHD();
        heroes[(int)19] = new ReinhardtHD();
        heroes[(int)20] = new RoadhogHD();
        heroes[(int)21] = new SigmaHD();
        heroes[(int)22] = new Soldier76HD();
        heroes[(int)23] = new SombraHD();
        */
        heroes[(int)24] = new SymmetraHD();
        /*
        heroes[(int)25] = new TorbjornHD();
        heroes[(int)26] = new TracerHD();
        heroes[(int)27] = new WidowmakerHD();
        heroes[(int)28] = new WinstonHD();
        heroes[(int)29] = new WreckingBallHD();
        heroes[(int)30] = new ZaryaHD();
        heroes[(int)31] = new ZenyattaHD();
        */
    }
}