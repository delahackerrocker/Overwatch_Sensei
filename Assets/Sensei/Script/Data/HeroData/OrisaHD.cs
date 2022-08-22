using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrisaHD : HeroData
{
    public OrisaHD() : base()
    {
        this.hero = HERO_ID.Orisa;
        this.health = 200;
        this.shields = 0;
        this.armor = 250;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "FUSION DRIVER";
        abilities[aCount].abilityDescription = "Automatic projectile weapon. Slows Orisa while firing.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionDriver";
        abilities[aCount].abilityVideo = hero + "/ability-fusion-driver";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PROTECTIVE BARRIER";
        abilities[aCount].abilityDescription = "Throw a device that creates a barrier.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ProtectiveBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-protective-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FORTIFY";
        abilities[aCount].abilityDescription = "Reduce damage taken and you cannot be stopped.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Fortify";
        abilities[aCount].abilityVideo = hero + "/ability-fortify";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "HALT!";
        abilities[aCount].abilityDescription = "Launch a graviton charge with Secondary Fire then detonate it with SECONDARY FIRE. The sphere slows and pulls nearby enemies to it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Halt";
        abilities[aCount].abilityVideo = hero + "/ability-halt";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SUPERCHARGER";
        abilities[aCount].abilityDescription = "Deploy a device that increases damage inflicted by your allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SuperCharger";
        abilities[aCount].abilityVideo = hero + "/ability-supercharger";
        abilities[aCount].controllerButton = ControllerButton.Y;
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