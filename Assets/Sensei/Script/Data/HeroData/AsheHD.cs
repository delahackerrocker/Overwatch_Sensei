using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsheHD : HeroData
{
    public AsheHD() : base()
    {
        this.hero = HERO_ID.Ashe;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        description = "Ashe quickly fires her rifle from the hip or uses her weapon’s aim-down sights to line up a high damage shot. She blasts enemies by throwing dynamite, and her coach gun packs enough punch to put some distance between her and her foes. And Ashe is not alone, as she can call on her omnic ally Bob, to join the fray when the need arises.";
        stars = 2;

        int aCount = 0;

        abilities = new AbilityData[5];
        abilities[aCount] = new AbilityData();
        abilities[aCount].abilityName = "THE VIPER";
        abilities[aCount].abilityDetail = "Semi-automatic rifle.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheViper";
        abilities[aCount].abilityVideo = hero + "/ability-the-viper";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 40;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 12;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.25f;
        abilities[aCount].recoverTime = 0.25f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TAKE AIM";
        abilities[aCount].abilityDetail = "Hold to zoom in, increasing damage and accuracy but slowing rate of fire.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheViper";
        abilities[aCount].abilityVideo = hero + "/ability-the-viper";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 75;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.25f;
        abilities[aCount].recoverTime = 0.65f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "COACH GUN";
        abilities[aCount].abilityDetail = "Blast enemies in front of you and knock yourself backwards.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CoachGun";
        abilities[aCount].abilityVideo = hero + "/ability-coach-gun";
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
        abilities[aCount].abilityName = "DYNAMITE";
        abilities[aCount].abilityDetail = "Throw an explosive that detonates after a short delay or immediately when shot.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Dynamite";
        abilities[aCount].abilityVideo = hero + "/ability-dynamite";
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
        abilities[aCount].abilityName = "B.O.B.";
        abilities[aCount].abilityDetail = "Deploy Bob. He charges forward and knocks enemies into the air, then attacks with his arm cannons.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BOB";
        abilities[aCount].abilityVideo = hero + "/ability-bob";
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