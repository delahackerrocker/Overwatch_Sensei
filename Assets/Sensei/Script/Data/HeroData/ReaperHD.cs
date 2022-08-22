using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaperHD : HeroData
{
    public ReaperHD() : base()
    {
        this.hero = HERO_ID.Reaper;
        this.health = 250;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Hellfire Shotguns, the ghostly ability to become immune to damage, and the power to step between shadows make Reaper one of the deadliest beings on Earth.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HELLFIRE SHOTGUNS";
        abilities[aCount].abilityDescription = "Short-range spread weapons.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HellfireShotguns";
        abilities[aCount].abilityVideo = hero + "/ability-hellfire-shotguns";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WRAITH FORM";
        abilities[aCount].abilityDescription = "Move faster and become invulnerable, but you cannot shoot.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WraithForm";
        abilities[aCount].abilityVideo = hero + "/ability-wraith-form";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SHADOW STEP";
        abilities[aCount].abilityDescription = "Teleport to a targeted location.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ShadowStep";
        abilities[aCount].abilityVideo = hero + "/ability-shadow-step";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "THE REAPING";
        abilities[aCount].abilityDescription = "Dealing damage heals you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheReaping";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEATH BLOSSOM";
        abilities[aCount].abilityDescription = "Damage all nearby enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DeathBlossom";
        abilities[aCount].abilityVideo = hero + "/ability-death-blossom";
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