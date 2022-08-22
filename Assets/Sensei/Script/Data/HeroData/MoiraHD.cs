using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoiraHD : HeroData
{
    public MoiraHD() : base()
    {
        this.hero = HERO_ID.Moira;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;
        int bCount = 0;

        description = "Moira’s biotic abilities enable her to contribute healing or damage in any crisis. While Biotic Grasp gives Moira short-range options, her Biotic Orbs contribute longer-range, hands-off damage and healing; she can also Fade to escape groups or remain close to allies in need of support. Once she’s charged Coalescence, Moira can save multiple allies from elimination at once or finish off weakened enemies.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC GRASP";
        abilities[aCount].abilityDescription = "Hold to heal all allies in front of you. Consumes biotic energy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticGrasp";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-grasp";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC GRASP - ALT FIRE";
        abilities[aCount].abilityDescription = "Long range beam weapon. Damage dealt heals you and replenishes your biotic energy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticGrasp";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-grasp";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FADE";
        abilities[aCount].abilityDescription = "Disappear, move faster, and become invulnerable, but you cannot shoot.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Fade";
        abilities[aCount].abilityVideo = hero + "/ability-fade";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC ORB";
        abilities[aCount].abilityDescription = "Launch a bouncing sphere that either heals nearby allies or damages nearby enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticOrb";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-orb";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "COALESCENCE";
        abilities[aCount].abilityDescription = "Fire a beam that heals allies and damages enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Coalescence";
        abilities[aCount].abilityVideo = hero + "/ability-coalescence";
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