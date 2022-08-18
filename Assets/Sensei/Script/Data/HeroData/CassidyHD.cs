using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassidyHD : HeroData
{
    public CassidyHD() : base()
    {
        this.hero = HERO_ID.Cassidy;
        this.health = 225;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Armed with his Peacekeeper revolver, Cassidy takes out targets with deadeye precision and dives out of danger with eagle-like speed.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PEACEKEEPER";
        abilities[aCount].abilityDetail = "Accurate, powerful revolver.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PeaceKeeper";
        abilities[aCount].abilityVideo = hero + "/ability-peacekeeper";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 70;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 6;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.5f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FAN THE HAMMER";
        abilities[aCount].abilityDetail = "Wildly fire remaining rounds.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PeaceKeeper";
        abilities[aCount].abilityVideo = hero + "/ability-peacekeeper";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 50;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 6;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 1.08f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "COMBAT ROLL";
        abilities[aCount].abilityDetail = "Roll in the direction you're moving and reload.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CombatRoll";
        abilities[aCount].abilityVideo = hero + "/ability-combat-roll";
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
        abilities[aCount].abilityName = "FLASHBANG";
        abilities[aCount].abilityDetail = "Stun enemies in front of you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FlashBang";
        abilities[aCount].abilityVideo = hero + "/ability-flashbang";
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
        abilities[aCount].abilityName = "DEADEYE";
        abilities[aCount].abilityDetail = "Face off against your enemies. Press Q to lock on, then Q or ABILITY 3 to fire.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DeadEye";
        abilities[aCount].abilityVideo = hero + "/ability-deadeye";
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