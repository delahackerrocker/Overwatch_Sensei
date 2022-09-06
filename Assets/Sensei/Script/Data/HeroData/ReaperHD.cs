using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReaperHD : HeroData
{
    public ReaperHD() : base()
    {
        this.hero = HERO_ID.Reaper;
        this.health = 250;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Hellfire Shotguns, the ghostly ability to become immune to damage, and the power to step between shadows make Reaper one of the deadliest beings on Earth.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HELLFIRE SHOTGUNS";
        abilities[aCount].abilityDescription = "Reaper tears enemies apart with twin shotguns.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HellfireShotguns";
        abilities[aCount].abilityVideo = hero + "/ability-hellfire-shotguns";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 1.8 - 6 per pellet\n        36 - 120 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 10 to 20 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> 6";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> 20 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 2 shots per second\n              extra delay while using meleee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 8";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WRAITH FORM";
        abilities[aCount].abilityDescription = "Reaper becomes a shadow for a short period of time. While in this form, he takes no damage and is able to pass through enemies, but cannot fire his weapons or use other abilities.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WraithForm";
        abilities[aCount].abilityVideo = hero + "/ability-wraith-form";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> +50% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.4 s. recovery time after end";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 0.8 seconds min. duration\n          3 seconds max. duration";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nReaper is cleansed of status effects and becomes immune to enemy damage and abilities.";
        abilities[aCount].abilityDetails[++bCount] = "\nAutomatically reloads Hellfire Shotguns to full ammo.";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be cancelled early.";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be used to take Health Packs.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SHADOW STEP";
        abilities[aCount].abilityDescription = "After marking a destination, Reaper disappears and reappears at that location.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ShadowStep";
        abilities[aCount].abilityVideo = hero + "/ability-shadow-step";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Max Range:</b> 35 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be used while Reaper is in the air, which will greatly reduce Reaper's fall speed while in use.";
        abilities[aCount].abilityDetails[++bCount] = "\nReaper is invulnerable when exiting.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "THE REAPING";
        abilities[aCount].abilityDescription = "Reaper steals health from his enemies as he damages them.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheReaping";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> 35% of damage dealt";
        abilities[aCount].abilityDetails[++bCount] = "\nCounts all damage from Reaper, even from quick melee or environmental kills.";
        abilities[aCount].abilityDetails[++bCount] = "\nDoes not generate ultimate charge.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEATH BLOSSOM";
        abilities[aCount].abilityDescription = "In a blur of motion, Reaper empties both Hellfire Shotguns at breakneck speed, dealing massive damage to all nearby enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DeathBlossom";
        abilities[aCount].abilityVideo = hero + "/ability-death-blossom";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 170 damage per second\n        34 damage per 0.192 sec\n        5 hits per sec, per target\n        510 damage overall";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -50% penalty";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 8 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 3 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2100 points";
        abilities[aCount].abilityDetails[++bCount] = "\nRestores Hellfire Shotguns ammo after the ability ends, provided the ability wasn't canceled prematurely.";

        strongAgainst = new HERO_ID[8];
        strongAgainst[0] = HERO_ID.Orisa;
        strongAgainst[1] = HERO_ID.Reinhardt;
        strongAgainst[2] = HERO_ID.Roadhog;
        strongAgainst[3] = HERO_ID.Sigma;
        strongAgainst[4] = HERO_ID.Zarya;
        strongAgainst[5] = HERO_ID.Winston;
        strongAgainst[6] = HERO_ID.Doomfist;
        strongAgainst[7] = HERO_ID.DVa;

        weakAgainst = new HERO_ID[7];
        weakAgainst[0] = HERO_ID.Ashe;
        weakAgainst[1] = HERO_ID.Genji;
        weakAgainst[2] = HERO_ID.Hanzo;
        weakAgainst[3] = HERO_ID.Junkrat;
        weakAgainst[4] = HERO_ID.Cassidy;
        weakAgainst[5] = HERO_ID.Widowmaker;
        weakAgainst[6] = HERO_ID.Pharah;
    }
}