using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WreckingBallHD : HeroData
{
    public WreckingBallHD() : base()
    {
        this.hero = HERO_ID.WreckingBall;
        this.health = 500;
        this.shields = 0;
        this.armor = 100;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Wrecking Ball rolls across the battlefield, using his arsenal of weapons and his mech’s powerful body to crush his enemies.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "QUAD CANNONS";
        abilities[aCount].abilityDescription = "Wrecking Ball’s automatic assault cannons tear apart threats at medium range.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/QuadCannons";
        abilities[aCount].abilityVideo = hero + "/ability-quad-cannons";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 1.5 - 5 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 15 to 25 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> ~2 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 25 shots per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 80";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 2.1 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nFirst two shots have perfect accuracy; bullet spread reaches max at 20 shots.";
        abilities[aCount].abilityDetails[++bCount] = "\nAutomatically reloads if Wrecking Ball is in his Roll.png Roll mode for <span seconds.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ROLL";
        abilities[aCount].abilityDescription = "Wrecking Ball transforms into a ball, increasing his maximum movement speed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Roll";
        abilities[aCount].abilityVideo = hero + "/ability-roll";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> 10 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "\nAfter returning to his normal form, Wrecking Ball can shoot after 0.3 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be cast while in midair.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball's base speed is the same in all directions (i.e. he is not slower going backwards).";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball rolls faster when going downhill. Going uphill does not affect his speed.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball automatically rolls downhill if he is not counteracting it.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball does not have a critical hitbox (Hammond's body is the 'head') and therefore cannot receive headshots.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball comes out of Roll if he is Hacked, slept, pinned, hooked, or knocked down; or if he tries to shoot.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ADAPTIVE SHIELD";
        abilities[aCount].abilityDescription = "Wrecking Ball’s temporary personal shields absorb damage, providing stronger defenses if more opponents are nearby.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AdaptiveShield";
        abilities[aCount].abilityVideo = hero + "/ability-adaptive-shield";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 100 temporary shields + 75 additional shields per enemy within radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 8 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 9 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nUnique to Wrecking Ball, the shields do not give ult charge to the enemy team when they damage it.";
        abilities[aCount].abilityDetails[++bCount] = "\nB.O.B. counts as an enemy for creating extra shields.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GRAPPLING CLAW";
        abilities[aCount].abilityDescription = "Wrecking Ball launches a grappling claw, enabling him to anchor to an area and swing from it. If he strikes an enemy with a powered-up swing, they’re damaged and knocked back.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GrapplingClaw";
        abilities[aCount].abilityVideo = hero + "/ability-grappling-claw";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 50 (high speed)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +100% buff (swinging)\n            18 m / s(rolling)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 23 meters (eventually retracts to 6 meters)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 6 seconds (max grapple time)\n          1.5 seconds(after release)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nAttaches to a surface, allowing Wrecking Ball to swing around the point of contact.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the line is more than 6 meters long and Wrecking Ball moves closer to the claw, the line retracts and stays retracted.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf cast in combat mode, Wrecking Ball enters Roll.";
        abilities[aCount].abilityDetails[++bCount] = "\nKnock back and damage is only applied when Wrecking Ball is powered-up (shown via a 'fireball' effect). Knocks enemies back up to 10 meters.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball is only powered-up while going at least 15 m/s. If Wrecking Ball is slowed by more than 25%, his swings cannot power-up at all.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball respawns with this ability on cooldown.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PILEDRIVER";
        abilities[aCount].abilityDescription = "Wrecking Ball slams onto the ground below, damaging enemies and launching them upward.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PileDriver";
        abilities[aCount].abilityVideo = hero + "/ability-piledriver";
        abilities[aCount].controllerButton = ControllerButton.B;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 20-100";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> 7.07 meters per second (charging)\n            98 meters per second(downwards)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 8 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1 second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nBound to Crouch/Toggle Crouch, which is unique to this ability.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball's altitude must be at least 2.25 meters to activate. For reference, jumping height is 0.98 meters.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball moves 4 meters forward before dropping.";
        abilities[aCount].abilityDetails[++bCount] = "\nAffected enemies are knocked into the air, and they lose air control for 0.5 seconds.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "MINEFIELD";
        abilities[aCount].abilityDescription = "Wrecking Ball deploys a field of long-lasting proximity mines which explode on contact with enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Minefield";
        abilities[aCount].abilityVideo = hero + "/ability-minefield";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 50 per mine";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 130 per mine";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 12 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 1.5 meter interact radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.1 seconds (deployment) + 0.3 s. recovery\n              1.5 seconds(mines, after landing)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 20 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1540 points";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball passively generates 1% Ult Charge every 3.08 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nDeploys 15 proximity mines around him, arranged into three rings of 1/6/8 mines.";
        abilities[aCount].abilityDetails[++bCount] = "\nActivating Minefield in the air increases the spread.";
        abilities[aCount].abilityDetails[++bCount] = "\nMines emit a high-pitched noise to nearby enemies.";
        abilities[aCount].abilityDetails[++bCount] = "\nWrecking Ball can regain ult charge while Minefield is deployed. However, damage from the mines does not count.";

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