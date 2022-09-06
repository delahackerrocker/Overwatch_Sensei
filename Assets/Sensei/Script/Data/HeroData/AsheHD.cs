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

        description = "Ashe quickly fires her rifle from the hip or uses her weapon?s aim-down sights to line up a high damage shot. She blasts enemies by throwing dynamite, and her coach gun packs enough punch to put some distance between her and her foes. And Ashe is not alone, as she can call on her omnic ally Bob, to join the fray when the need arises.";
        stars = 2;

        int aCount = 0;
        int bCount = 0;

        abilities = new AbilityData[5];
        abilities[aCount] = new AbilityData();
        abilities[aCount].abilityName = "THE VIPER";
        abilities[aCount].abilityDescription = "Semi-automatic rifle.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheViper";
        abilities[aCount].abilityVideo = hero + "/ability-the-viper";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 12 - 40";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 20 to 40 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Max: 1.85 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 0.256 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "             (~4 shots per second)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 12";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 0.5 seconds (initial animation)";
        abilities[aCount].abilityDetails[++bCount] = "            +0.25 seconds per bullet";
        abilities[aCount].abilityDetails[++bCount] = "            3.5 seconds (Full reload animation)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TAKE AIM";
        abilities[aCount].abilityDescription = "Hold to zoom in, increasing damage and accuracy but slowing rate of fire.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheViper";
        abilities[aCount].abilityVideo = hero + "/ability-the-viper";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 22.5 - 75";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 30 to 50 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -25% penalty";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 0.64 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "             (~1.54 shots per second)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 12";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 0.5 seconds (initial animation)";
        abilities[aCount].abilityDetails[++bCount] = "            +0.25 seconds per bullet";
        abilities[aCount].abilityDetails[++bCount] = "            3.5 seconds (Full reload animation)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "COACH GUN";
        abilities[aCount].abilityDescription = "Blast enemies in front of you and knock yourself backwards.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CoachGun";
        abilities[aCount].abilityVideo = hero + "/ability-coach-gun";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 6 per pellet";
        abilities[aCount].abilityDetails[++bCount] = "       90 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 9.4 meters (self-knock back)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> 15";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.16 seconds for cast + 0.4 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DYNAMITE";
        abilities[aCount].abilityDescription = "Throw an explosive that detonates after a short delay or immediately when shot.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Dynamite";
        abilities[aCount].abilityVideo = hero + "/ability-dynamite";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Explosion: 20 - 50";
        abilities[aCount].abilityDetails[++bCount] = "              Burn: 100";
        abilities[aCount].abilityDetails[++bCount] = "              Self: 50 % ";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.16 seconds for throw + 0.4 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "             2 seconds for explode after landing";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 5 seconds (burn)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 12 seconds";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "B.O.B.";
        abilities[aCount].abilityDescription = "Deploy Bob. He charges forward and knocks enemies into the air, then attacks with his arm cannons.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BOB";
        abilities[aCount].abilityVideo = hero + "/ability-bob";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 1200";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b>";
        abilities[aCount].abilityDetails[++bCount] = "   <b>Charge:</b> 120";
        abilities[aCount].abilityDetails[++bCount] = "   <b>Arm cannon:</b> 112 per second,";
        abilities[aCount].abilityDetails[++bCount] = "               14 per bullet,";
        abilities[aCount].abilityDetails[++bCount] = "               1092 overall";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> 15 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 70 meters (charge)";
        abilities[aCount].abilityDetails[++bCount] = "           40 meters (arm cannons)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 8 bullets per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.5 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 10 seconds (after collision)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2240 points";

        strongAgainst = new HERO_ID[6];
        strongAgainst[0] = HERO_ID.Ana;
        strongAgainst[1] = HERO_ID.Mercy;
        strongAgainst[2] = HERO_ID.Baptiste;
        strongAgainst[3] = HERO_ID.Pharah;
        strongAgainst[4] = HERO_ID.Reaper;
        strongAgainst[5] = HERO_ID.Torbjorn;

        weakAgainst = new HERO_ID[7];
        weakAgainst[0] = HERO_ID.Doomfist;
        weakAgainst[1] = HERO_ID.Genji;
        weakAgainst[2] = HERO_ID.Hanzo;
        weakAgainst[3] = HERO_ID.DVa;
        weakAgainst[4] = HERO_ID.Reinhardt;
        weakAgainst[5] = HERO_ID.Widowmaker;
        weakAgainst[6] = HERO_ID.WreckingBall;
    }
}