using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenjiHD : HeroData
{
    public GenjiHD() : base()
    {
        this.hero = HERO_ID.Genji;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;

        description = "Genji flings precise and deadly Shuriken at his targets, and uses his technologically-advanced katana to deflect projectiles or deliver a Swift Strike that cuts down enemies.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "SHURIKEN";
        abilities[aCount].abilityDetail = "Throw an accurate burst of 3 projectiles.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Shuriken";
        abilities[aCount].abilityVideo = hero + "/ability-shuriken";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 29;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 3;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 30;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.88f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FAN OF BLADES";
        abilities[aCount].abilityDetail = "Throw a fan of 3 projectiles in an arc.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Shuriken";
        abilities[aCount].abilityVideo = hero + "/ability-shuriken";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 1.5f;
        abilities[aCount].recoverTime = 0.68f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEFLECT";
        abilities[aCount].abilityDetail = "Deflect incoming projectiles towards the direction you are aiming and block melee attacks.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Deflect";
        abilities[aCount].abilityVideo = hero + "/ability-deflect";
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
        abilities[aCount].abilityName = "SWIFT STRIKE";
        abilities[aCount].abilityDetail = "Rapidly dash forward and inflict damage on enemies. Eliminations reset the cooldown.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SwiftStrike";
        abilities[aCount].abilityVideo = hero + "/ability-swift-strike";
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
        abilities[aCount].abilityName = "DRAGON BLADE";
        abilities[aCount].abilityDetail = "Unsheathe a deadly melee weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DragonBlade";
        abilities[aCount].abilityVideo = hero + "/ability-dragonblade";
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
        abilities[aCount].abilityName = "CYBER AGILITY";
        abilities[aCount].abilityDetail = "Unsheathe a deadly melee weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CyberAgility";
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