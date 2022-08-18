using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZenyattaHD : HeroData
{
    public ZenyattaHD() : base()
    {
        this.hero = HERO_ID.Zenyatta;
        this.health = 50;
        this.shields = 150;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;

        description = "Zenyatta calls upon orbs of harmony and discord to heal his teammates and weaken his opponents, all while pursuing a transcendent state of immunity to damage.";
        stars = 3;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ORB OF DESTRUCTION";
        abilities[aCount].abilityDetail = "Energy projectile weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfDestruction";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-destruction";
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
        abilities[aCount].abilityName = "ORB OF DESTRUCTION";
        abilities[aCount].abilityDetail = "Charge to release more projectiles.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfDestruction";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-destruction";
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
        abilities[aCount].abilityName = "ORB OF HARMONY";
        abilities[aCount].abilityDetail = "Launch this orb at an ally to heal them.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfHarmony";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-harmony";
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
        abilities[aCount].abilityName = "ORB OF DISCORD";
        abilities[aCount].abilityDetail = "Launch this orb at an enemy to increase the damage they take.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfDiscord";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-discord";
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
        abilities[aCount].abilityName = "TRANSCENDENCE";
        abilities[aCount].abilityDetail = "Become invulnerable, move faster, and heal nearby allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Transcendence";
        abilities[aCount].abilityVideo = hero + "/ability-transcendence";
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