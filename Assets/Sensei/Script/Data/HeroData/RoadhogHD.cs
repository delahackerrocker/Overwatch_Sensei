using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadhogHD : HeroData
{
    public RoadhogHD() : base()
    {
        this.hero = HERO_ID.Roadhog;
        this.health = 600;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Roadhog uses his signature Chain Hook to pull his enemies close before shredding them with blasts from his Scrap Gun. He’s hardy enough to withstand tremendous damage, and can recover his health with a short breather.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "SCRAP GUN";
        abilities[aCount].abilityDescription = "Short-range spread weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ScrapGun";
        abilities[aCount].abilityVideo = hero + "/ability-scrap-gun";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SCRAP GUN";
        abilities[aCount].abilityDescription = "Medium-range spread weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ScrapGun";
        abilities[aCount].abilityVideo = hero + "/ability-scrap-gun";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CHAIN HOOK";
        abilities[aCount].abilityDescription = "Drag a targeted enemy to you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ChainHook";
        abilities[aCount].abilityVideo = hero + "/ability-chain-hook";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TAKE A BREATHER";
        abilities[aCount].abilityDescription = "Heal yourself and reduce damage taken over a short time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TakeBreather";
        abilities[aCount].abilityVideo = hero + "/ability-take-a-breather";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WHOLE HOG";
        abilities[aCount].abilityDescription = "Damage and knock back enemies in front of you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WholeHog";
        abilities[aCount].abilityVideo = hero + "/ability-whole-hog";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        strongAgainst = new HERO_ID[8];
        strongAgainst[0] = HERO_ID.Ana;
        strongAgainst[1] = HERO_ID.Ashe;
        strongAgainst[2] = HERO_ID.Baptiste;
        strongAgainst[3] = HERO_ID.Bastion;
        strongAgainst[4] = HERO_ID.Brigitte;
        strongAgainst[5] = HERO_ID.Cassidy;
        strongAgainst[6] = HERO_ID.Doomfist;
        strongAgainst[7] = HERO_ID.DVa;

        weakAgainst = new HERO_ID[8];
        weakAgainst[0] = HERO_ID.Echo;
        weakAgainst[1] = HERO_ID.Genji;
        weakAgainst[2] = HERO_ID.Hanzo;
        weakAgainst[3] = HERO_ID.Junkrat;
        weakAgainst[4] = HERO_ID.Lucio;
        weakAgainst[5] = HERO_ID.Mei;
        weakAgainst[6] = HERO_ID.Mercy;
        weakAgainst[7] = HERO_ID.Moira;
    }
}