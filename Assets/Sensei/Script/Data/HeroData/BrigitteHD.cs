using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrigitteHD : HeroData
{
    public BrigitteHD() : base()
    {
        this.hero = HERO_ID.Brigitte;
        this.health = 200;
        this.shields = 0;
        this.armor = 50;
        this.role = Role.Support;

        int aCount = 0;
        int bCount = 0;

        description = "Brigitte specializes in armor. She can throw Repair Packs to heal teammates, or automatically heal nearby allies when she damages foes with her Flail. Her Flail is capable of a wide swing to strike multiple targets, or a Whip Shot that stuns an enemy at range. When entering the fray, Barrier Shield provides personal defense while she attacks enemies with Shield Bash. Brigitte’s ultimate ability, Rally, gives her a substantial short-term boost of speed and provides long-lasting armor to all her nearby allies.";
        stars = 1;

        abilities = new AbilityData[7];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ROCKET FLAIL";
        abilities[aCount].abilityDescription = "Brigitte's melee weapon has an extended range, enabling her to strike multiple enemies with a single swing.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketFlail";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-flail";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:35";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:6 meters";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 swing per 0.6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.208 second (initial swing)";
        abilities[aCount].abilityDetails[++bCount] = "              0.240 second (dealing damage)";
        abilities[aCount].abilityDetails[++bCount] = "              0.144 second (recovery after dealing damage ends)";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "At 5-6 meters away, Brigitte's flail has a horizontal range of 3 meters on the side she swings toward and 2 meters on the opposite side.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BARRIER SHIELD";
        abilities[aCount].abilityDescription = "Brigitte deploys a frontal energy barrier to absorb a limited amount of damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BarrierShield";
        abilities[aCount].abilityVideo = hero + "/ability-barrier-shield";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[5];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:250";
        abilities[aCount].abilityDetails[++bCount] = "Healing:Regenerates 85 barrier health per second, after being down for 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-30% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:5 seconds if destroyed";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SHIELD BASH";
        abilities[aCount].abilityDescription = "Once her Barrier Shield is deployed, Brigitte can dash forward to stun an enemy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BarrierShield";
        abilities[aCount].abilityVideo = hero + "/ability-barrier-shield";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[5];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:250";
        abilities[aCount].abilityDetails[++bCount] = "Healing:Regenerates 85 barrier health per second, after being down for 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-30% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:5 seconds if destroyed";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "REPAIR PACK";
        abilities[aCount].abilityDescription = "Heals an ally for a short duration.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RepairPack";
        abilities[aCount].abilityVideo = hero + "/ability-repair-pack";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:110 over 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:45 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:30 meters";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:3";
        abilities[aCount].abilityDetails[++bCount] = "Duration:2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds per charge, 3 charges";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WHIP SHOT";
        abilities[aCount].abilityDescription = "Brigitte throws her flail a long distance, dealing damage and knocking an enemy away from her.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WhipShot";
        abilities[aCount].abilityVideo = hero + "/ability-whip-shot";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:70";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-50% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:80 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:20 meters";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:0.5 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.2 seconds startup";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Whip Shot creates a strong knockback around 5 - 10 meters on the target.";
        abilities[aCount].abilityDetails[++bCount] = "At full length, it takes 0.3 seconds for the whip to retract.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RALLY";
        abilities[aCount].abilityDescription = "Brigitte moves faster and provides all nearby allies with armor that lasts until it’s removed by damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Rally";
        abilities[aCount].abilityVideo = hero + "/ability-rally";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:15 armor per 0.5 seconds, up to 100 armor on self and allies";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:+30% buff";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:8.5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.69 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:10 seconds, Armor lasts 30 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:2800 points";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "INSPIRE";
        abilities[aCount].abilityDescription = "Striking enemies with your flail heals nearby allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Inspire";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:15 per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:20 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Duration:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:1 second";
        abilities[aCount].abilityDetails[++bCount] = "Triggered by Rocket Flail.png Rocket Flail or Whip Shot.png Whip Shot, not Shield Bash.png Shield Bash.";
        abilities[aCount].abilityDetails[++bCount] = "Does not stack with itself. Instead, the duration resets.";
        abilities[aCount].abilityDetails[++bCount] = "Does not heal allies behind enemy barriers or surfaces that block line of sight.";
        abilities[aCount].abilityDetails[++bCount] = "Applies a heal-over-time effect to allies, meaning they do not have to continuously stay in range.";

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