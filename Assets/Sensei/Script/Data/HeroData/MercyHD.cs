using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercyHD : HeroData
{
    public MercyHD() : base()
    {
        this.hero = HERO_ID.Mercy;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;

        description = "";
        stars = 1;

        abilities = new AbilityData[7];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS STAFF";
        abilities[aCount].abilityDetail = "Hold to heal an ally.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusStaff";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-staff";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 55;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS BLASTER";
        abilities[aCount].abilityDetail = "Automatic weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusBlaster";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-blaster";
        abilities[aCount].controllerButton = ControllerButton.DPadRight;
        abilities[aCount].damage = 20;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 20;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.4f;
        abilities[aCount].recoverTime = 0.2f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS STAFF";
        abilities[aCount].abilityDetail = "Hold to increase an ally's damage inflicted.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusStaff";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-staff";
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
        abilities[aCount].abilityName = "RESURRECT";
        abilities[aCount].abilityDetail = "Revive a dead teammate.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Resurrect";
        abilities[aCount].abilityVideo = hero + "/ability-resurrect";
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
        abilities[aCount].abilityName = "ANGELIC DESCENT";
        abilities[aCount].abilityDetail = "Fall very slowly.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AngelicDescent";
        abilities[aCount].abilityVideo = hero + "/ability-angelic-descent";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "VALKYRIE";
        abilities[aCount].abilityDetail = "Gain the ability to fly. Abilities are enhanced.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Valkyrie";
        abilities[aCount].abilityVideo = hero + "/ability-valkyrie";
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
        abilities[aCount].abilityName = "REGENERATION";
        abilities[aCount].abilityDetail = "Automatically heal over time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Regeneration";
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