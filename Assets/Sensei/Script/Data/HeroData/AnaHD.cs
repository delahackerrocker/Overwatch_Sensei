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
        int bCount;
        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC RIFLE";
        abilities[aCount].abilityDescription = "Long-range rifle that heals allies and damages enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticRifle";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-rifle";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount=0] = "Damage:70 over 0.576 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "Healing:70 over 0.576 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Move Speed:-65% penalty (scoped)";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:125 meters per second (unscoped)";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:0.2 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 shot every 0.8 seconds 1.25 shots per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:12";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.5 seconds scope/unscope";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.576 seconds effect";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ZOOM";
        abilities[aCount].abilityDescription = "Hold to zoom in.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticRifle";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-rifle";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:70 over 0.576 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "Healing:70 over 0.576 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Move Speed:-65% penalty (scoped)";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:125 meters per second (unscoped)";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:0.2 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 shot every 0.8 seconds 1.25 shots per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:12";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.5 seconds scope/unscope";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.576 seconds effect";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";


        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SLEEP DART";
        abilities[aCount].abilityDescription = "Fires a dart that puts an enemy to sleep.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SleepDart";
        abilities[aCount].abilityVideo = hero + "/ability-sleep-dart";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:5";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:60 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:0.2 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.308 seconds for throw + 0.67 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:1.5 - 5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";


        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC GRENADE";
        abilities[aCount].abilityDescription = "Throws a grenade that heals and increases healing on allies, while damaging and preventing healing on enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticGrenade";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-grenade";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:60";
        abilities[aCount].abilityDetails[++bCount] = "Healing:100";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:30 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:4 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.67 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";


        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "NANO BOOST";
        abilities[aCount].abilityDescription = "Increases an ally's damage, while reducing damage taken.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/NanoBoost";
        abilities[aCount].abilityVideo = hero + "/ability-nano-boost";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:+50% damage buff";
        abilities[aCount].abilityDetails[++bCount] = "Healing:250 health";
        abilities[aCount].abilityDetails[++bCount] = "Dmg. reduction:50%";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:40 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.128 seconds + 0.67 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:2100 points";



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
