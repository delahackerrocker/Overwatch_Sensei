using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinstonHD : HeroData
{
    public WinstonHD() : base()
    {
        this.hero = HERO_ID.Winston;
        this.health = 400;
        this.shields = 0;
        this.armor = 150;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Winston wields impressive inventions—a jump pack, electricity-blasting Tesla Cannon, portable shield projector and more—with literal gorilla strength.";
        stars = 2;

        abilities = new AbilityData[4];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "TESLA CANNON";
        abilities[aCount].abilityDescription = "Electric frontal-cone weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TeslaCannon";
        abilities[aCount].abilityVideo = hero + "/ability-tesla-cannon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BARRIER PROJECTOR";
        abilities[aCount].abilityDescription = "Deploy a protective energy dome.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BarrierProjector";
        abilities[aCount].abilityVideo = hero + "/ability-barrier-projector";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "JUMP PACK";
        abilities[aCount].abilityDescription = "Leap forward into the air. Landing on an enemy damages them.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/JumpPack";
        abilities[aCount].abilityVideo = hero + "/ability-jump-pack";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PRIMAL RAGE";
        abilities[aCount].abilityDescription = "Gain immense health, but you can only leap and punch enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PrimalRage";
        abilities[aCount].abilityVideo = hero + "/ability-primal-rage";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
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