using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigmaHD : HeroData
{
    public SigmaHD() : base()
    {
        this.hero = HERO_ID.Sigma;
        this.health = 300;
        this.shields = 100;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Sigma is an eccentric astrophysicist and volatile tank who gained the power to control gravity in an orbital experiment gone wrong. Manipulated by Talon and deployed as a living weapon, Sigma’s presence on the battlefield cannot be ignored.";
        stars = 3;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HYPERSPHERES";
        abilities[aCount].abilityDescription = "Launch two charges which implode after a short duration, dealing damage in an area.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HyperSpheres";
        abilities[aCount].abilityVideo = hero + "/ability-hyperspheres";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EXPERIMENTAL BARRIER";
        abilities[aCount].abilityDescription = "Hold to propel a floating barrier; release to stop. Press again to recall the barrier to you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ExperimentalBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-experimental-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ACCRETION";
        abilities[aCount].abilityDescription = "Gather a mass of debris and throw it at an enemy to knock them down.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Accretion";
        abilities[aCount].abilityVideo = hero + "/ability-accretion";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "KINETIC GRASP";
        abilities[aCount].abilityDescription = "Absorb projectiles in front of you and convert them into shields.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/KineticGrasp";
        abilities[aCount].abilityVideo = hero + "/ability-kinetic-grasp";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GRAVITIC FLUX";
        abilities[aCount].abilityDescription = "Manipulate gravity to lift enemies into the air and slam them back down.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GraviticFlux";
        abilities[aCount].abilityVideo = hero + "/ability-gravitic-flux";
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