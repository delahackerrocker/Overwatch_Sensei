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
        heroes[0] = new AnaHD();
        heroes[1] = new AsheHD();
        heroes[2] = new BaptisteHD();
        heroes[3] = new BastionHD();
        heroes[4] = new BrigitteHD();
        heroes[5] = new CassidyHD();
        heroes[6] = new DVaHD();
        heroes[7] = new DoomfistHD();
        heroes[8] = new EchoHD();
        heroes[9] = new GenjiHD();
        /*
        heroes[10] = new HanzoHD();
        heroes[11] = new JunkratHD();
        heroes[12] = new LucioHD();
        heroes[13] = new MeiHD();
        heroes[14] = new MercyHD();
        heroes[15] = new MoiraHD();
        heroes[16] = new OrisaHD();
        heroes[17] = new PharahHD();
        heroes[18] = new ReaperHD();
        heroes[19] = new ReinhardtHD();
        heroes[20] = new RoadhogHD();
        heroes[21] = new SigmaHD();
        heroes[22] = new Soldier76HD();
        heroes[23] = new SombraHD();
        */
        heroes[24] = new SymmetraHD();
        /*
        heroes[25] = new TorbjornHD();
        heroes[26] = new TracerHD();
        heroes[27] = new WidowmakerHD();
        heroes[28] = new WinstonHD();
        heroes[29] = new WreckingBallHD();
        heroes[30] = new ZaryaHD();
        heroes[31] = new ZenyattaHD();
        */
    }
}