using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaHD : HeroData
{
    public AnaHD():base()
    {
        this.hero = HERO_ID.Ana;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        description = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power.";
        stars = 3;

        int aCount;
        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC RIFLE";
        abilities[aCount].abilityDetail = "Long-range rifle that heals allies and damages enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticRifle";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-rifle";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 70;
        abilities[aCount].healing = 70;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 12;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.8f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ZOOM";
        abilities[aCount].abilityDetail = "Hold to zoom in.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticRifle";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-rifle";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 70;
        abilities[aCount].healing = 70;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 12;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.8f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SLEEP DART";
        abilities[aCount].abilityDetail = "Fires a dart that puts an enemy to sleep.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SleepDart";
        abilities[aCount].abilityVideo = hero + "/ability-sleep-dart";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC GRENADE";
        abilities[aCount].abilityDetail = "Throws a grenade that heals and increases healing on allies, while damaging and preventing healing on enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticGrenade";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-grenade";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "NANO BOOST";
        abilities[aCount].abilityDetail = "Increases an ally's damage, while reducing damage taken.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/NanoBoost";
        abilities[aCount].abilityVideo = hero + "/ability-nano-boost";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

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
