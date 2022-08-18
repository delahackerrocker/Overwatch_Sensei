using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoHD : HeroData
{
    public EchoHD() : base()
    {
        this.hero = HERO_ID.Echo;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Echo is an evolutionary robot programmed with a rapidly adapting artificial intelligence, versatile enough to fill multiple battlefield combat roles.";
        stars = 2;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "TRI-SHOT";
        abilities[aCount].abilityDetail = "Fires 3 shots at once, in a triangle pattern.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TriShot";
        abilities[aCount].abilityVideo = hero + "/ability-tri-shot";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 17;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 3;
        abilities[aCount].ammo = 12;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.333f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STICKY BOMBS";
        abilities[aCount].abilityDetail = "Fire a volley of sticky bombs that detonate after a delay.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/StickyBombs";
        abilities[aCount].abilityVideo = hero + "/ability-sticky-bombs";
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
        abilities[aCount].abilityName = "FOCUSING BEAM";
        abilities[aCount].abilityDetail = "Channel a beam for a few seconds. Deals very high damage to targets under half health.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FocusingBeam";
        abilities[aCount].abilityVideo = hero + "/ability-focusing-beam";
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
        abilities[aCount].abilityName = "FLIGHT";
        abilities[aCount].abilityDetail = "Fly forward quickly and then free-fly briefly.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Flight";
        abilities[aCount].abilityVideo = hero + "/ability-flight";
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
        abilities[aCount].abilityName = "DUPLICATE";
        abilities[aCount].abilityDetail = "Become a copy of the targeted enemy hero. They cannot swap heroes for the duration.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Duplicate";
        abilities[aCount].abilityVideo = hero + "/ability-duplicate";
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
        abilities[aCount].abilityName = "GLIDE";
        abilities[aCount].abilityDetail = "Hold jump to glide while falling.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Glide";
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