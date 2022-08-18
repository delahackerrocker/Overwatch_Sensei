using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorbjornHD : HeroData
{
    public TorbjornHD() : base()
    {
        this.hero = HERO_ID.Torbjorn;
        this.health = 200;
        this.shields = 0;
        this.armor = 50;
        this.role = Role.Damage;

        int aCount = 0;

        description = "";
        stars = 2;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "RIVET GUN";
        abilities[aCount].abilityDetail = "Slow firing, long-ranged weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RivetGun";
        abilities[aCount].abilityVideo = hero + "/ability-rivet-gun";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RIVET GUN - ALT FIRE";
        abilities[aCount].abilityDetail = "Inaccurate but powerful short-range weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RivetGun";
        abilities[aCount].abilityVideo = hero + "/ability-rivet-gun";
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
        abilities[aCount].abilityName = "FORGE HAMMER";
        abilities[aCount].abilityDetail = "Swing to repair your turret or damage an enemy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ForgeHammer";
        abilities[aCount].abilityVideo = hero + "/ability-forge-hammer";
        abilities[aCount].controllerButton = ControllerButton.DPadLeft;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "OVERLOAD";
        abilities[aCount].abilityDetail = "Gain additional armor as well as improved attack, movement, and reload speed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Overload";
        abilities[aCount].abilityVideo = hero + "/ability-overload";
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
        abilities[aCount].abilityName = "DEPLOY TURRET";
        abilities[aCount].abilityDetail = "Deploy a self-building turret.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DeployTurret";
        abilities[aCount].abilityVideo = hero + "/ability-deploy-turret";
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
        abilities[aCount].abilityName = "MOLTEN CORE";
        abilities[aCount].abilityDetail = "Create pools of molten slag that damage enemies. Deals additional damage to armor.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MoltenCore";
        abilities[aCount].abilityVideo = hero + "/ability-molten-core";
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