using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigmaHD : HeroData
{
    public SigmaHD() : base()
    {
        this.hero = HERO_ID.Sigma;
        this.health = 300;
        this.shields = 100;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Sigma is an eccentric astrophysicist and volatile tank who gained the power to control gravity in an orbital experiment gone wrong. Manipulated by Talon and deployed as a living weapon, Sigma’s presence on the battlefield cannot be ignored.";
        stars = 3;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HYPERSPHERES";
        abilities[aCount].abilityDescription = "Sigma launches two gravitic charges, which bounce off walls and implode after a short duration, damaging enemies within a sizable radius.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HyperSpheres";
        abilities[aCount].abilityVideo = hero + "/ability-hyperspheres";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:2 charges per burst, each:\n        55 direct damage\n        9 - 30 splash damage\n        2.25 - 7.5 self damage";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:50 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:22 meters";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:3 meter implosion radius";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:2 shoots per 1.48 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:?";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "If Melee is used correctly after the second projectile, the time until the next attack will not be increased.";
        abilities[aCount].abilityDetails[++bCount] = "Bounces off walls, floors, and ceilings.";
        abilities[aCount].abilityDetails[++bCount] = "Enemies hurt by the implosion will be slightly pulled towards the center.";
        abilities[aCount].abilityDetails[++bCount] = "The charges automatically implode after travelling 22 meters.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EXPERIMENTAL BARRIER";
        abilities[aCount].abilityDescription = "Hold to propel a floating barrier; release to stop. Press again to recall the barrier to you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ExperimentalBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-experimental-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:700";
        abilities[aCount].abilityDetails[++bCount] = "Healing:Regenerates 80 barrier health per second, after being down for 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:16.5 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:?";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:4.5 meters height; 5 meters width at the poles, curves to 7 meters in the middle";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.064 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:2 seconds when recalled\n          5 seconds if destroyed";
        abilities[aCount].abilityDetails[++bCount] = "Upon activation, the barrier moves forward by holding down the ability key and stops when released.";
        abilities[aCount].abilityDetails[++bCount] = "The barrier can be removed by pressing the ability key again, keeping all its remaining health. This can be done at any time, including in the middle of other abilities such as Kinetic Grasp.";
        abilities[aCount].abilityDetails[++bCount] = "The barrier immediately returns to Sigma if he is eliminated or hacked.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ACCRETION";
        abilities[aCount].abilityDescription = "Sigma gathers a mass of debris and flings it at an enemy to knock them down.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Accretion";
        abilities[aCount].abilityVideo = hero + "/ability-accretion";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:70 direct damage\n        2 - 40 splash damage\n        6 - 20 self damage";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-75% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:37.5 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:4 meters knockback (direct)\n            1 - 2 meters knockback(splash)\n            2 meters knockback(self)";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:2.5 meter explosion radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.640 seconds for throw + 0.48 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.8 seconds knock down";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "The stone throw animation is 0.640 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "The stone can visually touch the wall, but not explode and fly further. Hitbox for wall explosions is smaller.";
        abilities[aCount].abilityDetails[++bCount] = "Ignores Deflect, Defense Matrix, and Kinetic Grasp.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "KINETIC GRASP";
        abilities[aCount].abilityDescription = "Sigma freezes incoming projectiles in midair, absorbing them into shields.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/KineticGrasp";
        abilities[aCount].abilityVideo = hero + "/ability-kinetic-grasp";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:60% of damage absorbed is converted to temporary shields (max. 400)";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:3 meters";
        abilities[aCount].abilityDetails[++bCount] = "Duration:2 seconds + 0.3 s. recovery (gain shields)";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Negates incoming projectiles from the front and sides, including ultimate abilities such as Graviton Surge, Blizzard, Dragonstrike (the arrow), etc.";
        abilities[aCount].abilityDetails[++bCount] = "Some abilities are given assigned values due their unorthodox nature. For example, the damage Biotic Orb is credited as 100 damage.";
        abilities[aCount].abilityDetails[++bCount] = "Can be cancelled with Accretion or ult. However, no shields will be gained if Kinetic Grasp is cancelled early.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GRAVITIC FLUX";
        abilities[aCount].abilityDescription = "Unleashing his full powers, Sigma takes flight, lifts enemies in a targeted area, and launches them into the sky before slamming them back down.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GraviticFlux";
        abilities[aCount].abilityVideo = hero + "/ability-gravitic-flux";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[15];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:50 damage (lift)\n        50 % max HP(slam)";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:7.15 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:35 meters";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:7 meter radius\n               lifts enemies up to 10.3 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.6 s. before can select the area & duration starts";
        abilities[aCount].abilityDetails[++bCount] = "Duration:Up to 5 seconds to select the area\n          1 second(from confirm to suspend)\n          Then after 2 seconds slam starts\n          After slam starts 0.6 s.high gravity";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1960 points";
        abilities[aCount].abilityDetails[++bCount] = "Sigma passively generates 1% Ult Charge every 3.92 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "Holding the Jump key causes Sigma to rise, while holding Crouch makes him descend.";
        abilities[aCount].abilityDetails[++bCount] = "Does not affect deployed objects such as turrets (but it does move Bastion in Sentry mode).";
        abilities[aCount].abilityDetails[++bCount] = "Disables all movement abilities of enemies suspended in the air, except Moira's Fade and Reaper's Wraith Form.";
        abilities[aCount].abilityDetails[++bCount] = "If the ability is interrupted before the slam, then there will be no slam and the enemies will no longer be under the influence of the ultimate.";
        abilities[aCount].abilityDetails[++bCount] = "If enemies escape the suspension, such as with Fortify or Cryo-Freeze, they fall down and no damage is inflicted.";
        abilities[aCount].abilityDetails[++bCount] = "The slam deals 50% of the maximum HP, which is increased by temporary HP gained from abilities such as Rally.";
        abilities[aCount].abilityDetails[++bCount] = "The lift can be damage boosted but not the slam.";

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