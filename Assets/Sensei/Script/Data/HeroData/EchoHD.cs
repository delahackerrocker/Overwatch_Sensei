using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoHD : HeroData
{
    public EchoHD() : base()
    {
        this.hero = HERO_ID.Echo;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Echo is an evolutionary robot programmed with a rapidly adapting artificial intelligence, versatile enough to fill multiple battlefield combat roles.";
        stars = 2;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "TRI-SHOT";
        abilities[aCount].abilityDescription = "Fires 3 shots at once, in a triangle pattern.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TriShot";
        abilities[aCount].abilityVideo = hero + "/ability-tri-shot";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:17 per pellet";
        abilities[aCount].abilityDetails[++bCount] = "          51 per shot";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:75 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Num. of pellets:3";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:0.3 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "             (3 shots per second)";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:12";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STICKY BOMBS";
        abilities[aCount].abilityDescription = "Echo fires a volley of sticky bombs that detonate after a delay.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/StickyBombs";
        abilities[aCount].abilityVideo = hero + "/ability-sticky-bombs";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:6 bombs";
        abilities[aCount].abilityDetails[++bCount] = "          Impact: 5";
        abilities[aCount].abilityDetails[++bCount] = "          Explosion: 25";
        abilities[aCount].abilityDetails[++bCount] = "          Self: 12.5";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:50 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:2 meter explosion radius";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 bomb per 0.064 seconds + 0.3 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:1 second (after stick)";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FOCUSING BEAM";
        abilities[aCount].abilityDescription = "Echo channels a beam for a few seconds, dealing very high damage to targets with less than half health.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FocusingBeam";
        abilities[aCount].abilityVideo = hero + "/ability-focusing-beam";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:50 per second";
        abilities[aCount].abilityDetails[++bCount] = "200 per second (target <50% hp)";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:16 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.24 s. recovery for shoot after end";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.24 seconds min duration";
        abilities[aCount].abilityDetails[++bCount] = "2 seconds max. duration";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Deals 4 times more damage if she is targeting something (including turrets or barriers) whose HP is 50% or lower.";
        abilities[aCount].abilityDetails[++bCount] = "Can be manually cancelled by pressing the ability key/button again.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FLIGHT";
        abilities[aCount].abilityDescription = "Echo surges forward quickly, then can fly freely.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Flight";
        abilities[aCount].abilityVideo = hero + "/ability-flight";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:8 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.2 seconds min. duration";
        abilities[aCount].abilityDetails[++bCount] = "         3 seconds max. duration";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Can be manually cancelled by pressing the button again.";
        abilities[aCount].abilityDetails[++bCount] = "Holding jump causes Echo to rise, while holding crouch causes her to descend.";
        abilities[aCount].abilityDetails[++bCount] = "When used, it adds to the speed of ~27 meters per second, after which it begins to sharply reduce the speed until it drops to 8 (~0.5 second).";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DUPLICATE";
        abilities[aCount].abilityDescription = "Become a copy of the targeted enemy hero and gains use of their abilities. They cannot swap heroes for the duration.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Duplicate";
        abilities[aCount].abilityVideo = hero + "/ability-duplicate";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Max. range:40 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.35 second activation + 1 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:2254 points";
        abilities[aCount].abilityDetails[++bCount] = "Echo's HP instantly becomes the full base HP of her target.";
        abilities[aCount].abilityDetails[++bCount] = "Echo's target cannot switch heroes for the duration of the ability.";
        abilities[aCount].abilityDetails[++bCount] = "While duplicating, Echo charges her ultimate ability 6.5 times faster.";
        abilities[aCount].abilityDetails[++bCount] = "When the duration ends, or if Echo's HP is reduced to 1, Echo reverts back to normal. Her HP returns back to what it was before, or 100 if her HP was less than 100.";
        abilities[aCount].abilityDetails[++bCount] = "Reverting back to Echo interrupts whatever ability she was using.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GLIDE";
        abilities[aCount].abilityDescription = "Hold jump to glide while falling.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Glide";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:Horizontal: +50% buff";
        abilities[aCount].abilityDetails[++bCount] = "                Vertical: 4 m/s (down)";

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