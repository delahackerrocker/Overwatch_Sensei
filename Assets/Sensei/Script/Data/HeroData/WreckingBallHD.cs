using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBallHD : HeroData
{
    public WreckingBallHD() : base()
    {
        this.hero = HERO_ID.WreckingBall;
        this.health = 500;
        this.shields = 0;
        this.armor = 100;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Wrecking Ball rolls across the battlefield, using his arsenal of weapons and his mech’s powerful body to crush his enemies.";
        stars = 3;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "QUAD CANNONS";
        abilities[aCount].abilityDescription = "Automatic assault weapons.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/QuadCannons";
        abilities[aCount].abilityVideo = hero + "/ability-quad-cannons";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ROLL";
        abilities[aCount].abilityDescription = "Transform into a ball and increase maximum movement speed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Roll";
        abilities[aCount].abilityVideo = hero + "/ability-roll";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ADAPTIVE SHIELD";
        abilities[aCount].abilityDescription = "Create temporary personal shields. Amount increases with more enemies nearby.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AdaptiveShield";
        abilities[aCount].abilityVideo = hero + "/ability-adaptive-shield";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GRAPPLING CLAW";
        abilities[aCount].abilityDescription = "Launch a grappling claw to rapidly swing around the area. Enables high speed collisions to damage and knockback enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GrapplingClaw";
        abilities[aCount].abilityVideo = hero + "/ability-grappling-claw";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "MINEFIELD";
        abilities[aCount].abilityDescription = "Deploy a massive field of proximity mines.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Minefield";
        abilities[aCount].abilityVideo = hero + "/ability-minefield";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

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