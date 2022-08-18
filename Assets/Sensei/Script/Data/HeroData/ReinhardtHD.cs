using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinhardtHD : HeroData
{
    public ReinhardtHD() : base()
    {
        this.hero = HERO_ID.Reinhardt;
        this.health = 300;
        this.shields = 0;
        this.armor = 200;
        this.role = Role.Tank;

        int aCount = 0;

        description = "Clad in powered armor and swinging his hammer, Reinhardt leads a rocket-propelled charge across the battleground and defends his squadmates with a massive energy barrier.";
        stars = 1;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ROCKET HAMMER";
        abilities[aCount].abilityDetail = "Devastating melee weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketHammer";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-hammer";
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
        abilities[aCount].abilityName = "BARRIER FIELD";
        abilities[aCount].abilityDetail = "Hold Secondary Fire to deploy a frontal energy barrier.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BarrierField";
        abilities[aCount].abilityVideo = hero + "/ability-barrier-field";
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
        abilities[aCount].abilityName = "CHARGE";
        abilities[aCount].abilityDetail = "Charge forward and smash an enemy against a wall.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Charge";
        abilities[aCount].abilityVideo = hero + "/ability-charge";
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
        abilities[aCount].abilityName = "FIRE STRIKE";
        abilities[aCount].abilityDetail = "Launch a fiery projectile.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FireStrike";
        abilities[aCount].abilityVideo = hero + "/ability-fire-strike";
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
        abilities[aCount].abilityName = "EARTHSHATTER";
        abilities[aCount].abilityDetail = "Knock down all enemies in front of you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/EarthShatter";
        abilities[aCount].abilityVideo = hero + "/ability-earthshatter";
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
        abilities[aCount].abilityName = "STEADFAST";
        abilities[aCount].abilityDetail = "Resistant to knock back effects.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Steadfast";
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