using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaptisteHD : HeroData
{
    public BaptisteHD() : base()
    {
        this.hero = HERO_ID.Baptiste;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        description = "Baptiste wields an assortment of experimental devices and weaponry to keep allies alive and eliminate threats under fierce conditions. A battle-hardened combat medic, he is just as capable of saving lives as he is taking out the enemy.";
        stars = 3;

        int aCount = 0;

        abilities = new AbilityData[7];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC LAUNCHER";
        abilities[aCount].abilityDetail = "Three-round burst gun.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-launcher";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 25;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 3;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 45;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = .58f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC LAUNCHER";
        abilities[aCount].abilityDetail = "Lob a healing projectile that heals all allies near the impact.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-launcher";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 70;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 10;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = .58f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "REGENERATIVE BURST";
        abilities[aCount].abilityDetail = "Activate to heal yourself and nearby allies over time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RegenerativeBurst";
        abilities[aCount].abilityVideo = hero + "/ability-regenerative-burst";
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
        abilities[aCount].abilityName = "IMMORTALITY FIELD";
        abilities[aCount].abilityDetail = "Toss a device that prevents allies from dying. The device can be destroyed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ImmortalityField";
        abilities[aCount].abilityVideo = hero + "/ability-immortality-field";
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
        abilities[aCount].abilityName = "AMPLIFICATION MATRIX";
        abilities[aCount].abilityDetail = "Project a matrix that doubles the damage and healing effects of allied projectiles.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AmplificationMatrix";
        abilities[aCount].abilityVideo = hero + "/ability-amplification-matrix";
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
        abilities[aCount].abilityName = "EXO BOOTS: CHARGE";
        abilities[aCount].abilityDetail = "Hold crouch to charge your Exo Boots.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ExoBoots";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.B;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EXO BOOTS: JUMP";
        abilities[aCount].abilityDetail = "Release the charge in your Exo Boots to increase the height of your jump. If there is no charge you will jump normally.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ExoBoots";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.A;
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