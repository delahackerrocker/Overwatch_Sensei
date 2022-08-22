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
        int bCount = 0;

        abilities = new AbilityData[5];
        abilities[aCount] = new AbilityData();
        abilities[aCount].abilityName = "THE VIPER";
        abilities[aCount].abilityDescription = "Semi-automatic rifle.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheViper";
        abilities[aCount].abilityVideo = hero + "/ability-the-viper";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:12 - 40";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:20 to 40 meters";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Max: 1.85 degrees";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:0.256 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "             (~4 shots per second)";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:12";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:0.5 seconds (initial animation)";
        abilities[aCount].abilityDetails[++bCount] = "            +0.25 seconds per bullet";
        abilities[aCount].abilityDetails[++bCount] = "            3.5 seconds (Full reload animation)";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TAKE AIM";
        abilities[aCount].abilityDescription = "Hold to zoom in, increasing damage and accuracy but slowing rate of fire.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheViper";
        abilities[aCount].abilityVideo = hero + "/ability-the-viper";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:22.5 - 75";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:30 to 50 meters";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-25% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:0.64 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "             (~1.54 shots per second)";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:12";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:0.5 seconds (initial animation)";
        abilities[aCount].abilityDetails[++bCount] = "            +0.25 seconds per bullet";
        abilities[aCount].abilityDetails[++bCount] = "            3.5 seconds (Full reload animation)";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "COACH GUN";
        abilities[aCount].abilityDescription = "Blast enemies in front of you and knock yourself backwards.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CoachGun";
        abilities[aCount].abilityVideo = hero + "/ability-coach-gun";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:6 per pellet";
        abilities[aCount].abilityDetails[++bCount] = "       90 per shot";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:9.4 meters (self-knock back)";
        abilities[aCount].abilityDetails[++bCount] = "Num. of pellets:15";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.16 seconds for cast + 0.4 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DYNAMITE";
        abilities[aCount].abilityDescription = "Throw an explosive that detonates after a short delay or immediately when shot.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Dynamite";
        abilities[aCount].abilityVideo = hero + "/ability-dynamite";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:Explosion: 20 - 50";
        abilities[aCount].abilityDetails[++bCount] = "              Burn: 100";
        abilities[aCount].abilityDetails[++bCount] = "              Self: 50 % ";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.16 seconds for throw + 0.4 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "             2 seconds for explode after landing";
        abilities[aCount].abilityDetails[++bCount] = "Duration:5 seconds (burn)";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:12 seconds";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "B.O.B.";
        abilities[aCount].abilityDescription = "Deploy Bob. He charges forward and knocks enemies into the air, then attacks with his arm cannons.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BOB";
        abilities[aCount].abilityVideo = hero + "/ability-bob";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:1200";
        abilities[aCount].abilityDetails[++bCount] = "Damage:Charge: 120";
        abilities[aCount].abilityDetails[++bCount] = "   Arm cannon: 112 per second,";
        abilities[aCount].abilityDetails[++bCount] = "               14 per bullet,";
        abilities[aCount].abilityDetails[++bCount] = "               1092 overall";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:15 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:70 meters (charge)";
        abilities[aCount].abilityDetails[++bCount] = "           40 meters (arm cannons)";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:8 bullets per second";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.5 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:10 seconds (after collision)";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:2240 points";

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