using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaryaHD : HeroData
{
    public ZaryaHD() : base()
    {
        this.hero = HERO_ID.Zarya;
        this.health = 200;
        this.shields = 200;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Deploying powerful personal barriers that convert incoming damage into energy for her massive Particle Cannon, Zarya is an invaluable asset on the front lines of any battle.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PARTICLE CANNON";
        abilities[aCount].abilityDescription = "Zarya’s mighty Particle Cannon unleashes a short-range beam of destructive energy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ParticleCannon";
        abilities[aCount].abilityVideo = hero + "/ability-particle-cannon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 75 per second (at 0%)\n       170 per second(at 100 %)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 15 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.15 meter beam width";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 20 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 100";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PARTICLE CANNON";
        abilities[aCount].abilityDescription = "Alternatively, Zarya can lob an explosive charge to strike multiple opponents.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ParticleCannon";
        abilities[aCount].abilityVideo = hero + "/ability-particle-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Enemy: 9.4-47 (at 0%)\n        Enemy: 19 - 95(at 100 %)\n        Self: 4.7 - 23.5(at 0 %)\n        Self: 9.5 - 47.5(at 100 %)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 2.5 meter radius (explosion)\n              0.2 meter radius(projectile)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 shot per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 100";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 25 rounds per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.48 s. recovery for primary fire";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PROJECTED BARRIER";
        abilities[aCount].abilityDescription = "Zarya surrounds one of her teammates with an energy barrier that simultaneously absorbs fire and boosts the power of her Particle Cannon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ProjectedBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-projected-barrier";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 200";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 30 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 1.5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nProjected Barrier behaves identically to Particle Barrier. For more ability details, see Particle Barrier.";
        abilities[aCount].abilityDetails[++bCount] = "\nAlthough the barrier prevents the target from being Ability Sombra Hack.png hacked, slept, or stunned in the first place, it does not interrupt those effects once already applied.";
        abilities[aCount].abilityDetails[++bCount] = "\nProjected Barrier unfreezes frozen targets.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PARTICLE BARRIER";
        abilities[aCount].abilityDescription = "The Particle Cannon can emit a personal barrier that shields Zarya against incoming attacks, redirecting their energy to enhance her weapon’s damage and the width of its beam.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ParticleBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-particle-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 200";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 1.5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nZarya gains 0.2% Energy per damage blocked by the barrier, or 1% Energy per 5 damage blocked.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe barrier cleanses Zarya of most status and damage over time effects.";
        abilities[aCount].abilityDetails[++bCount] = "\nWhile the barrier is up, Zarya is immune to all damage and most Crowd Control effects, even if the attack pierces barriers such as Rocket punch.png Rocket Punch.";
        abilities[aCount].abilityDetails[++bCount] = "\nDoes not protect Zarya from knockback.";
        abilities[aCount].abilityDetails[++bCount] = "\nEven if the barrier is destroyed, it will protect Zarya from the attack.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GRAVITON SURGE";
        abilities[aCount].abilityDescription = "Zarya launches a gravity bomb that draws in enemy combatants and deals damage while they’re trapped.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GravitonSurge";
        abilities[aCount].abilityVideo = hero + "/ability-graviton-surge";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Impact: 5\n        Damage over time: 5 per second, up to 18.72";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 6 meter radius (gravity)\n              0.2 meter radius(projectile)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.4 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2100 points";
        abilities[aCount].abilityDetails[++bCount] = "\nMost movement abilities are disabled within the effect of Graviton Surge.\n - Exceptions: Reaper's Ability-reaper2.png Wraith Form and Moira's Ability Moira Fade.png Fade.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ENERGY";
        abilities[aCount].abilityDescription = "Damage blocked by barriers increases Particle Cannon damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Energy";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[5];
        abilities[aCount].abilityDetails[bCount = 0] = "Energy is gained by blocking damage with Particle and Projected Barrier (max. 100%).";
        abilities[aCount].abilityDetails[++bCount] = "\nEnergy decays at a rate of 1.8% per second.";
        abilities[aCount].abilityDetails[++bCount] = "\nEnergy instantly resets to 0 upon death. (Resurrect does not restore Energy.)";
        abilities[aCount].abilityDetails[++bCount] = "\nThe more Energy Zarya has, the brighter she glows.";
        abilities[aCount].abilityDetails[++bCount] = "\n50% or higher is considered 'High Energy.'";

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