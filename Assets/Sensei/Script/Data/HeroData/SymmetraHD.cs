using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymmetraHD : HeroData
{
    public SymmetraHD() : base()
    {
        this.hero = HERO_ID.Symmetra;
        this.health = 100;
        this.shields = 125;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Symmetra utilizes her Photon Projector to dispatch adversaries, shield her associates, construct teleportation pads and deploy particle-blasting Sentry Turrets.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PHOTON PROJECTOR";
        abilities[aCount].abilityDetail = "Short-range beam weapon with increasing damage. Damaging Barriers does not consume ammunition.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Symmetra";
        abilities[aCount].abilityVideo = hero + "/ability-photon-projector";
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
        abilities[aCount].abilityName = "PHOTON PROJECTOR";
        abilities[aCount].abilityDetail = "Hold to charge, release to fire explosive orb.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Symmetra";
        abilities[aCount].abilityVideo = hero + "/ability-photon-projector";
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
        abilities[aCount].abilityName = "TELEPORTER";
        abilities[aCount].abilityDetail = "Create two teleporters that enable instant travel between them.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Teleporter";
        abilities[aCount].abilityVideo = hero + "/ability-teleporter";
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
        abilities[aCount].abilityName = "SENTRY TURRET";
        abilities[aCount].abilityDetail = "Deploy a small turret that damages and slows enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SentryTurret";
        abilities[aCount].abilityVideo = hero + "/ability-sentry-turret";
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
        abilities[aCount].abilityName = "PHOTON BARRIER";
        abilities[aCount].abilityDetail = "Deploy a massive energy barrier.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PhotonBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-photon-barrier";
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