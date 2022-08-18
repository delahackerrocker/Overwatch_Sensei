using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomfistHD : HeroData
{
    public DoomfistHD() : base()
    {
        this.hero = HERO_ID.Doomfist;
        this.health = 250;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Doomfist’s cybernetics make him a highly-mobile, powerful frontline fighter. In addition to dealing ranged damage with his Hand Cannon, Doomfist can slam the ground, knock enemies into the air and off balance, or charge into the fray with his Rocket Punch. When facing a tightly packed group, Doomfist leaps out of view, then crashes down to earth with a spectacular Meteor Strike.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HAND CANNON";
        abilities[aCount].abilityDetail = "Short-range weapon with spread. Reloads automatically.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HandCannon";
        abilities[aCount].abilityVideo = hero + "/ability-hand-cannon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 6;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 11;
        abilities[aCount].ammo = 4;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.65f;
        abilities[aCount].recoverTime = 0.333f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SEISMIC SLAM";
        abilities[aCount].abilityDetail = "Leap forward and smash the ground.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SeismicSlam";
        abilities[aCount].abilityVideo = hero + "/ability-seismic-slam";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RISING UPPERCUT";
        abilities[aCount].abilityDetail = "Knock an enemy into the air.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RisingUppercut";
        abilities[aCount].abilityVideo = hero + "/ability-rising-uppercut";
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
        abilities[aCount].abilityName = "ROCKET PUNCH";
        abilities[aCount].abilityDetail = "Hold to charge then release to launch forward and knock an enemy back. Damage increases if the enemy hits a wall.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketPunch";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-punch";
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
        abilities[aCount].abilityName = "METEOR STRIKE";
        abilities[aCount].abilityDetail = "Press Q to leap up into the air. Move the targeting circle, then press ABILITY 3 to strike the targeted area.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MeteorStrike";
        abilities[aCount].abilityVideo = hero + "/ability-meteor-strike";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "THE BEST DEFENSE...";
        abilities[aCount].abilityDetail = "Dealing damage with abilities creates temporary personal shields.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheBestDefense";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
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