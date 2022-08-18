using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidowmakerHD : HeroData
{
    public WidowmakerHD() : base()
    {
        this.hero = HERO_ID.Widowmaker;
        this.health = 175;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Widowmaker equips herself with whatever it takes to eliminate her targets, including mines that dispense poisonous gas, a visor that grants her squad infra-sight, and a powerful sniper rifle that can fire in fully-automatic mode.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "WIDOW'S KISS";
        abilities[aCount].abilityDetail = "Automatic assault weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WidowsKiss";
        abilities[aCount].abilityVideo = hero + "/ability-widows-kiss";
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
        abilities[aCount].abilityName = "SNIPER MODE";
        abilities[aCount].abilityDetail = "Hold for long-ranged sniper weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WidowsKiss";
        abilities[aCount].abilityVideo = hero + "/intro-video";
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
        abilities[aCount].abilityName = "VENOM MINE";
        abilities[aCount].abilityDetail = "Launch a poison trap.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/VenomMine";
        abilities[aCount].abilityVideo = hero + "/ability-venom-mine";
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
        abilities[aCount].abilityName = "GRAPPLING HOOK";
        abilities[aCount].abilityDetail = "Launch a hook that pulls you towards a ledge.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GrapplingHook";
        abilities[aCount].abilityVideo = hero + "/ability-grappling-hook";
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
        abilities[aCount].abilityName = "INFRA-SIGHT";
        abilities[aCount].abilityDetail = "Provide your team with a view of the enemy's location.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/InfraSight";
        abilities[aCount].abilityVideo = hero + "/ability-infra-sight";
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