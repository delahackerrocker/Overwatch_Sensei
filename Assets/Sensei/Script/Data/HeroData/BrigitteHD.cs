using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrigitteHD : HeroData
{
    public BrigitteHD() : base()
    {
        this.hero = HERO_ID.Brigitte;
        this.health = 200;
        this.shields = 0;
        this.armor = 50;
        this.role = Role.Support;

        int aCount = 0;

        description = "Brigitte specializes in armor. She can throw Repair Packs to heal teammates, or automatically heal nearby allies when she damages foes with her Flail. Her Flail is capable of a wide swing to strike multiple targets, or a Whip Shot that stuns an enemy at range. When entering the fray, Barrier Shield provides personal defense while she attacks enemies with Shield Bash. Brigitte’s ultimate ability, Rally, gives her a substantial short-term boost of speed and provides long-lasting armor to all her nearby allies.";
        stars = 1;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ROCKET FLAIL";
        abilities[aCount].abilityDetail = "Melee weapon with extended range.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketFlail";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-flail";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 35;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.6f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BARRIER SHIELD";
        abilities[aCount].abilityDetail = "Hold Secondary Fire to deploy a frontal energy barrier.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BarrierShield";
        abilities[aCount].abilityVideo = hero + "/ability-barrier-shield";
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
        abilities[aCount].abilityName = "REPAIR PACK";
        abilities[aCount].abilityDetail = "Heals an ally for a short duration.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RepairPack";
        abilities[aCount].abilityVideo = hero + "/ability-repair-pack";
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
        abilities[aCount].abilityName = "WHIP SHOT";
        abilities[aCount].abilityDetail = "Launch your flail forward to knock an enemy away from you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WhipShot";
        abilities[aCount].abilityVideo = hero + "/ability-whip-shot";
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
        abilities[aCount].abilityName = "RALLY";
        abilities[aCount].abilityDetail = "Move faster and provide armor to nearby allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Rally";
        abilities[aCount].abilityVideo = hero + "/ability-rally";
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
        abilities[aCount].abilityName = "INSPIRE";
        abilities[aCount].abilityDetail = "Striking enemies with your flail heals nearby allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Inspire";
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