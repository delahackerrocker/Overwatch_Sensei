using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BastionHD : HeroData
{
    public BastionHD() : base()
    {
        this.hero = HERO_ID.Bastion;
        this.health = 200;
        this.shields = 0;
        this.armor = 100;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Repair protocols and the ability to transform between stationary Assault, mobile Recon and devastating Tank configurations provide Bastion with a high probability of victory.";
        stars = 1;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "CONFIGURATION:\nRECON";
        abilities[aCount].abilityDetail = "Mobile with a light automatic weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConfigurationSentry";
        abilities[aCount].abilityVideo = hero + "/ability-configuration-recon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 20;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 35;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.125f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SELF-REPAIR";
        abilities[aCount].abilityDetail = "Hold to heal yourself.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SelfRepair";
        abilities[aCount].abilityVideo = hero + "/ability-self-repair";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 15;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 300;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 2.1f;
        abilities[aCount].recoverTime = 0.033f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RECONFIGURE";
        abilities[aCount].abilityDetail = "Switch between weapon configurations.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Reconfigure";
        abilities[aCount].abilityVideo = hero + "/ability-reconfigure";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].damage = 205;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 1f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CONFIGURATION:\nSentry";
        abilities[aCount].abilityDetail = "";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConfigurationSentry";
        abilities[aCount].abilityVideo = hero + "/ability-configuration-sentry";
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
        abilities[aCount].abilityName = "CONFIGURATION:\nTANK";
        abilities[aCount].abilityDetail = "Mobile with a powerful cannon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConfigurationTank";
        abilities[aCount].abilityVideo = hero + "/ability-configuration-tank";
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
        abilities[aCount].abilityName = "IRONCLAD";
        abilities[aCount].abilityDetail = "Reduces damage taken while transformed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/IronClad";
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