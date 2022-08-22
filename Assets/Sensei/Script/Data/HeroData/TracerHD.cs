using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerHD : HeroData
{
    public TracerHD() : base()
    {
        this.hero = HERO_ID.Tracer;
        this.health = 150;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Toting twin pulse pistols, energy-based time bombs, and rapid-fire banter, Tracer is able to 'blink' through space and rewind her personal timeline as she battles to right wrongs the world over.";
        stars = 2;

        abilities = new AbilityData[4];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PULSE PISTOLS";
        abilities[aCount].abilityDescription = "Short-range automatic weapons.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PulsePistols";
        abilities[aCount].abilityVideo = hero + "/ability-pulse-pistols";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BLINK";
        abilities[aCount].abilityDescription = "Teleport in the direction you are moving.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Blink";
        abilities[aCount].abilityVideo = hero + "/ability-blink";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RECALL";
        abilities[aCount].abilityDescription = "Travel back in time to your previous location and health.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Recall";
        abilities[aCount].abilityVideo = hero + "/ability-recall";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PULSE BOMB";
        abilities[aCount].abilityDescription = "Throw out a powerful sticky explosive.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PulseBomb";
        abilities[aCount].abilityVideo = hero + "/ability-pulse-bomb";
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