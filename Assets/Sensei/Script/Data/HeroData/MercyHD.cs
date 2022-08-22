using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercyHD : HeroData
{
    public MercyHD() : base()
    {
        this.hero = HERO_ID.Mercy;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;
        int bCount = 0;

        description = "";
        stars = 1;

        abilities = new AbilityData[7];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS STAFF";
        abilities[aCount].abilityDescription = "Hold to heal an ally.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusStaff";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-staff";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS BLASTER";
        abilities[aCount].abilityDescription = "Automatic weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusBlaster";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-blaster";
        abilities[aCount].controllerButton = ControllerButton.DPadRight;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS STAFF";
        abilities[aCount].abilityDescription = "Hold to increase an ally's damage inflicted.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusStaff";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-staff";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RESURRECT";
        abilities[aCount].abilityDescription = "Revive a dead teammate.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Resurrect";
        abilities[aCount].abilityVideo = hero + "/ability-resurrect";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ANGELIC DESCENT";
        abilities[aCount].abilityDescription = "Fall very slowly.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AngelicDescent";
        abilities[aCount].abilityVideo = hero + "/ability-angelic-descent";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "VALKYRIE";
        abilities[aCount].abilityDescription = "Gain the ability to fly. Abilities are enhanced.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Valkyrie";
        abilities[aCount].abilityVideo = hero + "/ability-valkyrie";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "REGENERATION";
        abilities[aCount].abilityDescription = "Automatically heal over time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Regeneration";
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