using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkratHD : HeroData
{
    public JunkratHD() : base()
    {
        this.hero = HERO_ID.Junkrat;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Junkrat’s area-denying armaments include a Frag Launcher that lobs bouncing grenades, Concussion Mines that send enemies flying, and Steel Traps that stop foes dead in their tracks.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "FRAG LAUNCHER";
        abilities[aCount].abilityDetail = "Bouncing explosive projectile weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FragLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-frag-launcher";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 120;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 5;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.666f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CONCUSSION MINE";
        abilities[aCount].abilityDetail = "Throw a knockback mine with LSHIFT then detonate it with ABILITY 1.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConcussionMine";
        abilities[aCount].abilityVideo = hero + "/ability-concussion-mine";
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
        abilities[aCount].abilityName = "STEEL TRAP";
        abilities[aCount].abilityDetail = "Place an immobilizing trap.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SteelTrap";
        abilities[aCount].abilityVideo = hero + "/ability-steel-trap";
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
        abilities[aCount].abilityName = "RIP-TIRE";
        abilities[aCount].abilityDetail = "Drive and detonate an exploding tire.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RipTire";
        abilities[aCount].abilityVideo = hero + "/ability-rip-tire";
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
        abilities[aCount].abilityName = "TOTAL MAYHEM";
        abilities[aCount].abilityDetail = "Deals no damage to self with explosives. Drop bombs on death.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TotalMayhem";
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