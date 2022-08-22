using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanzoHD : HeroData
{
    public HanzoHD() : base()
    {
        this.hero = HERO_ID.Hanzo;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Hanzo’s versatile arrows can reveal his enemies or fragment to strike multiple targets. He can scale walls to fire his bow from on high, or summon a titanic spirit dragon.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "STORM BOW";
        abilities[aCount].abilityDescription = "Hold to charge then release to launch arrows further.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/StormBow";
        abilities[aCount].abilityVideo = hero + "/ability-storm-bow";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STORM ARROWS";
        abilities[aCount].abilityDescription = "The next 5 arrows fire instantly at reduced damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/StormArrows";
        abilities[aCount].abilityVideo = hero + "/ability-storm-arrows";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SONIC ARROW";
        abilities[aCount].abilityDescription = "Reveals enemies for a short time upon impact.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SonicArrow";
        abilities[aCount].abilityVideo = hero + "/ability-sonic-arrow";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "LUNGE";
        abilities[aCount].abilityDescription = "Double Jump.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Lunge";
        abilities[aCount].abilityVideo = hero + "/ability-lunge";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DRAGON STRIKE";
        abilities[aCount].abilityDescription = "Launch a deadly Dragon Spirit that devastates enemies it passes through.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DragonStrike";
        abilities[aCount].abilityVideo = hero + "/ability-dragonstrike";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WALL CLIMB";
        abilities[aCount].abilityDescription = "Jump at walls to climb up them.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WallClimb";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
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