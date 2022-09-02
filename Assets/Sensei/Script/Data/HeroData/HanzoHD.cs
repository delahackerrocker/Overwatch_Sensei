using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HanzoHD : HeroData
{
    public HanzoHD() : base()
    {
        this.hero = HERO_ID.Hanzo;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Hanzo’s versatile arrows can reveal his enemies or fragment to strike multiple targets. He can scale walls to fire his bow from on high, or summon a titanic spirit dragon.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "STORM BOW";
        abilities[aCount].abilityDescription = "Hanzo nocks and fires an arrow at his target. Hold to charge then release to launch arrows further.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/StormBow";
        abilities[aCount].abilityVideo = hero + "/ability-storm-bow";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 27.2 - 125 (depending on charge)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -30% penalty";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 - 110 m/s";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.1 meters arrow radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> ?";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly starts charge + 0.5 s. recovery after shot extra recovery while using melee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nThe max cast time is not limited.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe minimum power required to kill a full health target (without armor) with a single headshot:\n   150 HP = 0.368 second.\n   200 HP = 0.560 second.\n   225 HP = 0.640 second.\n   250 HP = 0.732 second.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STORM ARROWS";
        abilities[aCount].abilityDescription = "Hanzo’s next several arrows fire instantly, but at reduced damage. These arrows can ricochet once.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/StormArrows";
        abilities[aCount].abilityVideo = hero + "/ability-storm-arrows";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 70";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 110 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.1 meters arrow radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 shot per 0.24 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 5";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.24 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Up to 5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nStorm Arrows travel at the same speed as fully charged Storm Bow arrows.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SONIC ARROW";
        abilities[aCount].abilityDescription = "Hanzo launches an arrow that contains a sonar tracking device. Any enemy within its detection radius is visibly marked, making them easier for Hanzo and his allies to hunt down.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SonicArrow";
        abilities[aCount].abilityVideo = hero + "/ability-sonic-arrow";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[5];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Area of Effect:</b> 9 meter vision radius\n              0.1 meters arrow radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nPressing the ability key turns the next arrow from Storm Bow or Storm Arrows into a Sonic Arrow. (This does not change the speed or damage.) Pressing the key again before firing changes it back.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the arrow becomes stuck on a moving target (e.g. an enemy hero), the effect follows.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "LUNGE";
        abilities[aCount].abilityDescription = "Hanzo can double jump, allowing him to change direction mid-jump.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Lunge";
        abilities[aCount].abilityVideo = hero + "/ability-lunge";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> 15 meters per second (horizontal)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 7.85 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 5 seconds";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DRAGON STRIKE";
        abilities[aCount].abilityDescription = "Hanzo summons a Spirit Dragon which travels through the air in a line. It passes through walls in its way, devouring any enemies it encounters.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DragonStrike";
        abilities[aCount].abilityVideo = hero + "/ability-dragonstrike";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Arrow: 125\n             Dragons: 150 damage per second, per dragon\n              Up to 993.6 damage against a stationary target";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 20 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> Infinite travel distance";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 4 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1.5 seconds charging";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.912 seconds (charging)\n            0.6 seconds (arrow fly time)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1680 points";
        abilities[aCount].abilityDetails[++bCount] = "\nHanzo passively generates 1% Ult Charge every 3.36 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nDoes not affect enemy objects.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe hitbox is actually both dragons, meaning the ultimate deals less damage at the edges, and combined at the center.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WALL CLIMB";
        abilities[aCount].abilityDescription = "Jump at walls to climb up them.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WallClimb";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> 7.8 meters per second (vertical)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> Up to 4 meter vertical climb";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Up to 1 second";

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