using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeiHD : HeroData
{
    public MeiHD() : base()
    {
        this.hero = HERO_ID.Mei;
        this.health = 250;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Mei’s weather-altering devices slow opponents and protect locations. Her Endothermic Blaster unleashes damaging icicles and frost streams, and she can Cryo-Freeze herself to guard against counterattacks, or obstruct the opposing team's movements with an Ice Wall.";
        stars = 3;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ENDOTHERMIC BLASTER";
        abilities[aCount].abilityDescription = "Mei’s blaster unleashes a concentrated, short-range stream of frost that damages, slows, and ultimately freezes enemies in place.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/EndothermicBlaster";
        abilities[aCount].abilityVideo = hero + "/ability-endothermic-blaster";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:55 per second\n               2.75 per round";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-20% at first, then -2.85% per tick (max. -70%)";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:20 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:10 meters";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:120";
        abilities[aCount].abilityDetails[++bCount] = "Ammo usage:20 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Duration:1 second (slow effect)\n               1.3 seconds(frozen)";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "The first tick results in a 20% progress towards the freeze (also inflicts a 20% slow effect), then each subsequent tick increases this by 2.85% (also inflicts a 2.85% slow effect). (The slow effect is capped at 70%.) At 100% or higher freeze progress, the very next tick freezes the target; therefore, it takes a total of 31 rounds in order to freeze.";
        abilities[aCount].abilityDetails[++bCount] = "The slow effect lasts for 1 second after the last tick of damage was dealt.";
        abilities[aCount].abilityDetails[++bCount] = "Pierces enemies.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ICICLE";
        abilities[aCount].abilityDescription = "Mei can also use her blaster to shoot icicle-like projectiles at medium range.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/EndothermicBlaster";
        abilities[aCount].abilityVideo = hero + "/ability-endothermic-blaster";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:75";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:115 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 shot per 0.8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:120";
        abilities[aCount].abilityDetails[++bCount] = "Ammo usage:10 per shot";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.4 seconds + 0.4 s. recovery for shoot";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Endothermic Blaster's alternate fire is also called 'Icicle.'";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CRYO-FREEZE";
        abilities[aCount].abilityDescription = "Mei instantly surrounds herself with a block of thick ice. She heals and ignores damage while encased, but cannot move or use abilities.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CryoFreeze";
        abilities[aCount].abilityVideo = hero + "/ability-cryo-freeze";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:~50 per second\n             Up to 200 overall";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.44 seconds min. duration\n               3 seconds max. duration\n               0.24 seconds recovery";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Restores 15 ammo per second (max. 60).";
        abilities[aCount].abilityDetails[++bCount] = "The cooldown starts only after the effect wears off.";
        abilities[aCount].abilityDetails[++bCount] = "The ability can be cancelled prematurely.";
        abilities[aCount].abilityDetails[++bCount] = "Mei becomes completely invincible and is cleared of all status effects.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ICE WALL";
        abilities[aCount].abilityDescription = "Mei generates an enormous ice wall that obstructs lines of sight, stops movement, and blocks attacks.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/IceWall";
        abilities[aCount].abilityVideo = hero + "/ability-ice-wall";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:400 per pillar\n            5 pillars";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:35 meters";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:3x8 meters area";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:intstantly + 0.5 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:Up to 5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Can be manually destroyed by pressing the ability key again, including while dead.";
        abilities[aCount].abilityDetails[++bCount] = "Before casting, the Ice Wall's placement from the player's line of sight can be toggled from perpendicular to parallel by pressing the hotkey.";
        abilities[aCount].abilityDetails[++bCount] = "The cooldown starts immediately, not when the wall destroyed.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BLIZZARD";
        abilities[aCount].abilityDescription = "Mei deploys a weather-modification drone that emits gusts of wind and snow in a wide area. Enemies caught in the blizzard are slowed and take damage; those who linger too long are frozen solid.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Blizzard";
        abilities[aCount].abilityVideo = hero + "/ability-blizzard";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:20 per second\n               Up to 85 over the duration";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-50% at first, then -20% per second (max. -70%)";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:20 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:10 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.5 seconds (throw)";
        abilities[aCount].abilityDetails[++bCount] = "Duration:4.25 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1610 points";
        abilities[aCount].abilityDetails[++bCount] = "The first tick results in a 50% progress towards the freeze (also inflicts a 50% slow effect), then it continues at a rate of 20% per second (also slows at a rate of 20% per second). (The slow effect is capped at 70%.) At 100% or higher freeze progress, the very next tick freezes the target; therefore, it takes about 2.5 seconds in order to freeze.";
        abilities[aCount].abilityDetails[++bCount] = "Using Endothermic Blaster's primary fire greatly speeds up the freezing process.";
        abilities[aCount].abilityDetails[++bCount] = "Pierces barriers, payloads, and Ice Wall.";

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