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

    public HeroData[] heroes = new HeroData[32];

    private void Start()
    {
        InitializeAllHeroData();
    }

    void InitializeAllHeroData()
    {
        int count;
        // Ana
        heroes[count = 0] = new HeroData(HERO_ID.Ana, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Ashe
        heroes[count = 1] = new HeroData(HERO_ID.Ashe, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Baptiste
        heroes[count = 2] = new HeroData(HERO_ID.Baptiste, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Bastion
        heroes[count = 3] = new HeroData(HERO_ID.Bastion, 200, 0, 100);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Brigitte
        heroes[count = 4] = new HeroData(HERO_ID.Brigitte, 200, 0, 50);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Cassidy
        heroes[count = 5] = new HeroData(HERO_ID.Cassidy, 225, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Doomfist
        heroes[count = 6] = new HeroData(HERO_ID.Doomfist, 250, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // DVa
        heroes[count = 7] = new HeroData(HERO_ID.DVa, 300, 300, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Echo
        heroes[count = 8] = new HeroData(HERO_ID.Echo, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Genji
        heroes[count = 9] = new HeroData(HERO_ID.Genji, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Hanzo
        heroes[count = 10] = new HeroData(HERO_ID.Hanzo, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Junkrat
        heroes[count = 11] = new HeroData(HERO_ID.Junkrat, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Lucio
        heroes[count = 12] = new HeroData(HERO_ID.Lucio, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Mei
        heroes[count = 13] = new HeroData(HERO_ID.Mei, 250, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Mercy
        heroes[count = 14] = new HeroData(HERO_ID.Mercy, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Moira
        heroes[count = 15] = new HeroData(HERO_ID.Moira, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Orisa
        heroes[count = 16] = new HeroData(HERO_ID.Orisa, 200, 0, 250);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Pharah
        heroes[count = 17] = new HeroData(HERO_ID.Pharah, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Reaper
        heroes[count = 18] = new HeroData(HERO_ID.Reaper, 250, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Reinhardt
        heroes[count = 19] = new HeroData(HERO_ID.Reinhardt, 300, 200, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Roadhog
        heroes[count = 20] = new HeroData(HERO_ID.Roadhog, 600, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Sigma
        heroes[count = 21] = new HeroData(HERO_ID.Sigma, 300, 100, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Soldier76
        heroes[count = 22] = new HeroData(HERO_ID.Soldier76, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Sombra
        heroes[count = 23] = new HeroData(HERO_ID.Sombra, 200, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Symmetra
        heroes[count = 24] = new HeroData(HERO_ID.Symmetra, 100, 125, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Torbjorn
        heroes[count = 25] = new HeroData(HERO_ID.Torbjorn, 200, 0, 50);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Tracer
        heroes[count = 26] = new HeroData(HERO_ID.Tracer, 150, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Widowmaker
        heroes[count = 27] = new HeroData(HERO_ID.Widowmaker, 175, 0, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Winston
        heroes[count = 28] = new HeroData(HERO_ID.Winston, 400, 0, 150);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // WreckingBall
        heroes[count = 29] = new HeroData(HERO_ID.WreckingBall, 500, 0, 100);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Zarya
        heroes[count = 30] = new HeroData(HERO_ID.Zarya, 200, 200, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

        // Zenyatta
        heroes[count = 31] = new HeroData(HERO_ID.Zenyatta, 50, 150, 0);
        heroes[count].abilities = new AbilityData[5];
        heroes[count].abilities[0].abilityName = "";
        heroes[count].abilities[0].abilityDetail = "";
        heroes[count].abilities[0].controllerButton = ControllerButton.RightTrigger;
        heroes[count].abilities[1].abilityName = "";
        heroes[count].abilities[1].abilityDetail = "";
        heroes[count].abilities[1].controllerButton = ControllerButton.LeftTrigger;
        heroes[count].abilities[2].abilityName = "";
        heroes[count].abilities[2].abilityDetail = "";
        heroes[count].abilities[2].controllerButton = ControllerButton.RightBumper;
        heroes[count].abilities[3].abilityName = "";
        heroes[count].abilities[3].abilityDetail = "";
        heroes[count].abilities[3].controllerButton = ControllerButton.LeftBumper;
        heroes[count].abilities[4].abilityName = "";
        heroes[count].abilities[4].abilityDetail = "";
        heroes[count].abilities[4].controllerButton = ControllerButton.Passive;

    }
}