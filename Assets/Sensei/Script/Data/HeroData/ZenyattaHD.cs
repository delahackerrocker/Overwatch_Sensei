using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZenyattaHD : HeroData
{
    public ZenyattaHD() : base()
    {
        this.hero = HERO_ID.Zenyatta;
        this.health = 50;
        this.shields = 150;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;
        int bCount = 0;

        description = "Zenyatta calls upon orbs of harmony and discord to heal his teammates and weaken his opponents, all while pursuing a transcendent state of immunity to damage.";
        stars = 3;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ORB OF DESTRUCTION";
        abilities[aCount].abilityDescription = "Zenyatta projects his destructive energy orbs individually.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfDestruction";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-destruction";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 48";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 90 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.15 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 shot every 0.4 second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 20";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ORB OF DESTRUCTION ALT";
        abilities[aCount].abilityDescription = "Zenyatta projects his destructive energy orbs in a rapid-fire volley after a few seconds spent gathering power.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfDestruction";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-destruction";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 48 per orb\n        Max 240 per volley";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 90 mps\n           1 orb per 0.524 seconds (charging)\n         0.608 seconds recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 20";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> Up to 5 per volley";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ORB OF HARMONY";
        abilities[aCount].abilityDescription = "Zenyatta casts an orb over the shoulder of a targeted ally. So long as Zenyatta maintains line of sight, the orb slowly restores health to his ally. Only one ally can receive the orb's benefit at a time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfHarmony";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-harmony";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> 30 health per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 90 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 40 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> One active";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 3 seconds (if out of sight)";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Zenyatta loses sight of the player being healed, Orb of Harmony will be returned to Zenyatta after 3 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nMultiple orbs stack additively.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ORB OF DISCORD";
        abilities[aCount].abilityDescription = "Attaching the orb of discord to an opponent amplifies the amount of damage they receive for as long as Zenyatta maintains line of sight. Only one opponent can suffer the orb's effects at a time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/OrbOfDiscord";
        abilities[aCount].abilityVideo = hero + "/ability-orb-of-discord";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> +25% damage received";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 90 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 40 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> One active";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 3 seconds (if out of sight)";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Zenyatta loses sight of the player afflicted, Orb of Discord will be returned to Zenyatta after 3 seconds.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TRANSCENDENCE";
        abilities[aCount].abilityDescription = "Zenyatta enters a state of heightened existence for a short period of time. While transcendent, Zenyatta cannot use abilities or weapons, but is immune to damage and automatically restores his health and that of nearby allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Transcendence";
        abilities[aCount].abilityVideo = hero + "/ability-transcendence";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> 300 health per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> 11 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 10 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2310 points";
        abilities[aCount].abilityDetails[++bCount] = "\nZenyatta is also immune to certain stuns, such as Hack and Earthshatter.";
        abilities[aCount].abilityDetails[++bCount] = "\nAmmunition is restored after completion.";

        strongAgainst = new HERO_ID[5];
        strongAgainst[0] = HERO_ID.DVa;
        strongAgainst[1] = HERO_ID.Bastion;
        strongAgainst[2] = HERO_ID.Pharah;
        strongAgainst[3] = HERO_ID.Roadhog;
        strongAgainst[4] = HERO_ID.Zarya;

        weakAgainst = new HERO_ID[8];
        weakAgainst[0] = HERO_ID.Sombra;
        weakAgainst[1] = HERO_ID.Doomfist;
        weakAgainst[2] = HERO_ID.Genji;
        weakAgainst[3] = HERO_ID.Cassidy;
        weakAgainst[4] = HERO_ID.Mei;
        weakAgainst[5] = HERO_ID.Reaper;
        weakAgainst[6] = HERO_ID.Tracer;
        weakAgainst[7] = HERO_ID.Widowmaker;
    }
}