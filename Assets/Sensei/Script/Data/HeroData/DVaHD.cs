using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DVaHD : HeroData
{
    public DVaHD() : base()
    {
        this.hero = HERO_ID.DVa;
        this.health = 300;
        this.shields = 300;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "D.Va?s mech is nimble and powerful?its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix.";
        stars = 2;

        abilities = new AbilityData[8];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "FUSION CANNONS";
        abilities[aCount].abilityDescription = "D.Va's mech is equipped with twin short-range rotating cannons. They lay down continuous, high-damage fire without needing to reload, but slow D.Va?s movement while they?re active.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionCannons";
        abilities[aCount].abilityVideo = hero + "/ability-fusion-cannons";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 0.6 - 2";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 10 - 20 m";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> 4.15 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -40% penalty, except when using Boosters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> 11 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 0.16 seconds recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> Infinite";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "LIGHT GUN";
        abilities[aCount].abilityDescription = "";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionCannons";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 14";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 50 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 7 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 20";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage Per Second:</b>  98.00 while firing (this can also be considered as a burst DPS rate), 65.01 overall";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEFENSE MATRIX";
        abilities[aCount].abilityDescription = "D.Va can activate this forward-facing targeting array to shoot incoming projectiles out of the air.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DefenseMatrix";
        abilities[aCount].abilityVideo = hero + "/ability-defense-matrix";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Max Range:</b> 10 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 0.5 seconds min. duration";
        abilities[aCount].abilityDetails[++bCount] = "                  2 seconds max. duration";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 1 second";
        abilities[aCount].abilityDetails[++bCount] = "\nD.Va cannot use Fusion Cannons while the ability is active.";
        abilities[aCount].abilityDetails[++bCount] = "\nUses a resource meter that, after a 0.75 second delay, recharges at a rate of 16% per second.";
        abilities[aCount].abilityDetails[++bCount] = "\nTakes 7 seconds to fully recharge.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BOOSTERS";
        abilities[aCount].abilityDescription = "D.Va?s mech launches into the air, her momentum carrying her forward. She can turn and change directions or barrel through her enemies, knocking them back.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Boosters";
        abilities[aCount].abilityVideo = hero + "/ability-boosters";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 10";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +118% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> Up to 23.98 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 0.4 seconds min. duration";
        abilities[aCount].abilityDetails[++bCount] = "                2 seconds max duration";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nThe cooldown triggers after the Boosters ability ends.";
        abilities[aCount].abilityDetails[++bCount] = "\nCancelled upon using quick melee.";
        abilities[aCount].abilityDetails[++bCount] = "\nDoes not affect Fusion Cannons or Micro Missiles' accuracy.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "MICRO MISSILES";
        abilities[aCount].abilityDescription = "D.Va launches a volley of explosive rockets.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MicroMissiles";
        abilities[aCount].abilityVideo = hero + "/ability-micro-missiles";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Direct hit: 7 per missile";
        abilities[aCount].abilityDetails[++bCount] = "              Splash: 1 - 4 per missile";
        abilities[aCount].abilityDetails[++bCount] = "              Self: 1 - 4 per missile";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 40 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 1.5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 11 missiles per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 18";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.25 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nDeals up to 126 total damage. (8.18% ultimate charge)";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be used alongside Fusion Cannons.";
        abilities[aCount].abilityDetails[++bCount] = "\nCannot be manually cancelled.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SELF - DESTRUCT";
        abilities[aCount].abilityDescription = "D.Va ejects from her mech and sets its reactor to explode, dealing massive damage to nearby opponents";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SelfDestruct";
        abilities[aCount].abilityVideo = hero + "/ability-self-destruct";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 100 - 1000";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 20 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 3-second fuse";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1540 points";
        abilities[aCount].abilityDetails[++bCount] = "\nThe detonating mech retains the momentum from Boosters.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EJECT!";
        abilities[aCount].abilityDescription = "D.Va's mech will automatically eject her when it reaches 1 Health. This forces D.Va into Pilot Form.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Eject";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[4];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 150 health";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nD.Va can use Self-Destruct while ejecting.";
        abilities[aCount].abilityDetails[++bCount] = "\nD.Va is invulnerable while ejecting.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CALL MECH";
        abilities[aCount].abilityDescription = "If her armored battle suit is destroyed, D.Va can call down a fresh mech and return to the fray.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CallMech";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 300 health";
        abilities[aCount].abilityDetails[++bCount] = "         300 armor";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 250";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 2.5 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.91 seconds for damage + 0.1 for sit in mech + 2 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 319.2 points";
        abilities[aCount].abilityDetails[++bCount] = "\nBecomes completely charged after Self-Destruct detonates, or if D.Va is Resurrected.";
        abilities[aCount].abilityDetails[++bCount] = "\nAutomatically reloads the Light Gun.";

        strongAgainst = new HERO_ID[8];
        strongAgainst[0] = HERO_ID.Ana;
        strongAgainst[1] = HERO_ID.Ashe;
        strongAgainst[2] = HERO_ID.Hanzo;
        strongAgainst[3] = HERO_ID.Bastion;
        strongAgainst[4] = HERO_ID.Mercy;
        strongAgainst[5] = HERO_ID.Pharah;
        strongAgainst[6] = HERO_ID.Cassidy;
        strongAgainst[7] = HERO_ID.Moira;

        weakAgainst = new HERO_ID[8];
        weakAgainst[0] = HERO_ID.Baptiste;
        weakAgainst[1] = HERO_ID.Brigitte;
        weakAgainst[2] = HERO_ID.Doomfist;
        weakAgainst[3] = HERO_ID.Junkrat;
        weakAgainst[4] = HERO_ID.Reaper;
        weakAgainst[5] = HERO_ID.Mei;
        weakAgainst[6] = HERO_ID.Sombra;
        weakAgainst[7] = HERO_ID.Zarya;
    }
}