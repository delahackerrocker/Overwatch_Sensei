using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier76HD : HeroData
{
    public Soldier76HD() : base()
    {
        this.hero = HERO_ID.Soldier76;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Armed with cutting-edge weaponry, including an experimental pulse rifle that’s capable of firing spirals of high-powered Helix Rockets, Soldier: 76 has the speed and support know-how of a highly trained warrior.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HEAVY PULSE RIFLE";
        abilities[aCount].abilityDetail = "Automatic assault weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HeavyPulseRifle";
        abilities[aCount].abilityVideo = hero + "/ability-heavy-pulse-rifle";
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
        abilities[aCount].abilityName = "HELIX ROCKETS";
        abilities[aCount].abilityDetail = "Launch a volley of explosive rockets.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HelixRockets";
        abilities[aCount].abilityVideo = hero + "/ability-helix-rockets";
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
        abilities[aCount].abilityName = "BIOTIC FIELD";
        abilities[aCount].abilityDetail = "Deploy a field that heals you and your allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticField";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-field";
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
        abilities[aCount].abilityName = "SPRINT";
        abilities[aCount].abilityDetail = "Run faster while moving forward.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Sprint";
        abilities[aCount].abilityVideo = hero + "/ability-sprint";
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
        abilities[aCount].abilityName = "TACTICAL VISOR";
        abilities[aCount].abilityDetail = "Automatically aims your weapon at targets in view.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TacticalVisor";
        abilities[aCount].abilityVideo = hero + "/ability-tactical-visor";
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