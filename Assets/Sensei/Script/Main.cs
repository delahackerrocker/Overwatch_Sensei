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
        int hCount = 0;
        int aCount = 0;

        heroes[hCount = 0] = new AnaHD();
        heroes[hCount = 1] = new AsheHD();
        heroes[hCount = 2] = new BaptisteHD();
        heroes[hCount = 3] = new BastionHD();
        heroes[hCount = 4] = new BrigitteHD();
        heroes[hCount = 5] = new CassidyHD();
        heroes[hCount = 6] = new DVaHD();
        heroes[hCount = 7] = new DoomfistHD();
        heroes[hCount = 8] = new EchoHD();
        heroes[hCount = 9] = new GenjiHD();
        heroes[hCount = 10] = new HanzoHD();
        heroes[hCount = 11] = new JunkratHD();
        heroes[hCount = 12] = new LucioHD();
        heroes[hCount = 13] = new MeiHD();
        heroes[hCount = 14] = new MercyHD();
        heroes[hCount = 15] = new MoiraHD();
        heroes[hCount = 16] = new OrisaHD();
        heroes[hCount = 17] = new PharahHD();
        heroes[hCount = 18] = new ReaperHD();
        heroes[hCount = 19] = new ReinhardtHD();
        heroes[hCount = 20] = new RoadhogHD();
        heroes[hCount = 21] = new SigmaHD();
        heroes[hCount = 22] = new Soldier76HD();
        heroes[hCount = 23] = new SombraHD();
        heroes[hCount = 24] = new SymmetraHD();
        heroes[hCount = 25] = new TorbjornHD();
        heroes[hCount = 26] = new TracerHD();
        heroes[hCount = 27] = new WidowmakerHD();
        heroes[hCount = 28] = new WinstonHD();
        heroes[hCount = 29] = new WreckingBallHD();
        heroes[hCount = 30] = new ZaryaHD();
        heroes[hCount = 31] = new ZenyattaHD();
    }
}