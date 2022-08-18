using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVaHD : HeroData
{
    public DVaHD() : base()
    {
        this.hero = HERO_ID.DVa;
        this.health = 300;
        this.shields = 300;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;

        description = "D.Va’s mech is nimble and powerful—its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix.";
        stars = 2;

        abilities = new AbilityData[7];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "FUSION CANNONS";
        abilities[aCount].abilityDetail = "Automatic short-range spread weapons.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionCannons";
        abilities[aCount].abilityVideo = hero + "/ability-fusion-cannons";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 2;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 11;
        abilities[aCount].ammo = 0;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0f;
        abilities[aCount].recoverTime = 0.15f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "LIGHT GUN";
        abilities[aCount].abilityDetail = "";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionCannons";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 14;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 20;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.45f;
        abilities[aCount].recoverTime = 0.1428f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEFENSE MATRIX";
        abilities[aCount].abilityDetail = "Block projectiles in an area in front of you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DefenseMatrix";
        abilities[aCount].abilityVideo = hero + "/ability-defense-matrix";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.45f;
        abilities[aCount].recoverTime = 0.1428f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BOOSTERS";
        abilities[aCount].abilityDetail = "Fly in the direction you are facing.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Boosters";
        abilities[aCount].abilityVideo = hero + "/ability-boosters";
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
        abilities[aCount].abilityName = "MICRO MISSILES";
        abilities[aCount].abilityDetail = "Launch a volley of explosive rockets.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MicroMissiles";
        abilities[aCount].abilityVideo = hero + "/ability-micro-missiles";
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
        abilities[aCount].abilityName = "SELF - DESTRUCT";
        abilities[aCount].abilityDetail = "Eject and overload your mech, causing it to explode after a short time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SelfDestruct";
        abilities[aCount].abilityVideo = hero + "/ability-self-destruct";
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
        abilities[aCount].abilityName = "EJECT!";
        abilities[aCount].abilityDetail = "Eject out of your mech when it is destroyed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Eject";
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