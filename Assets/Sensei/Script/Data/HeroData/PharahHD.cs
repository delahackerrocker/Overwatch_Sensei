using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PharahHD : HeroData
{
    public PharahHD() : base()
    {
        this.hero = HERO_ID.Pharah;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Soaring through the air in her combat armor, and armed with a launcher that lays down high-explosive rockets, Pharah is a force to be reckoned with.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ROCKET LAUNCHER";
        abilities[aCount].abilityDescription = "Long-range explosive projectile weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-launcher";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "HOVER JETS";
        abilities[aCount].abilityDescription = "Hold to hover.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HoverJets";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CONCUSSIVE BLAST";
        abilities[aCount].abilityDescription = "Launch an explosive blast to knock back enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConcussiveBlast";
        abilities[aCount].abilityVideo = hero + "/ability-concussive-blast";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "JUMP JET";
        abilities[aCount].abilityDescription = "Fly rapidly upwards.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/JumpJet";
        abilities[aCount].abilityVideo = hero + "/ability-jump-jet";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BARRAGE";
        abilities[aCount].abilityDescription = "Launch a continuous volley of mini-rockets.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Barrage";
        abilities[aCount].abilityVideo = hero + "/ability-barrage";
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