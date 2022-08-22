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

        description = "D.Va’s mech is nimble and powerful—its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix.";
        stars = 2;

        abilities = new AbilityData[8];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "FUSION CANNONS";
        abilities[aCount].abilityDescription = "D.Va's mech is equipped with twin short-range rotating cannons. They lay down continuous, high-damage fire without needing to reload, but slow D.Va’s movement while they’re active.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionCannons";
        abilities[aCount].abilityVideo = hero + "/ability-fusion-cannons";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:0.6 - 2";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:10 - 20 m";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Constant: 4.15 degrees";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-40% penalty, except when using Boosters";
        abilities[aCount].abilityDetails[++bCount] = "Num. of pellets:11 per shot";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:0.16 seconds recovery";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:Infinite";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "LIGHT GUN";
        abilities[aCount].abilityDescription = "";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionCannons";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:14";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:50 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:7 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:20";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Damage per second: 98.00 while firing (this can also be considered as a burst DPS rate), 65.01 overall";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEFENSE MATRIX";
        abilities[aCount].abilityDescription = "D.Va can activate this forward-facing targeting array to shoot incoming projectiles out of the air.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DefenseMatrix";
        abilities[aCount].abilityVideo = hero + "/ability-defense-matrix";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Max. range:10 meters";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.5 seconds min. duration";
        abilities[aCount].abilityDetails[++bCount] = "         2 seconds max. duration";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:1 second";
        abilities[aCount].abilityDetails[++bCount] = "D.Va cannot use Ability-dva1.png Fusion Cannons while the ability is active.";
        abilities[aCount].abilityDetails[++bCount] = "Uses a resource meter that, after a 0.75 second delay, recharges at a rate of 16% per second.";
        abilities[aCount].abilityDetails[++bCount] = "Takes 7 seconds to fully recharge.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BOOSTERS";
        abilities[aCount].abilityDescription = "D.Va’s mech launches into the air, her momentum carrying her forward. She can turn and change directions or barrel through her enemies, knocking them back.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Boosters";
        abilities[aCount].abilityVideo = hero + "/ability-boosters";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:10";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:+118% buff";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:Up to 23.98 meters";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.4 seconds min. duration";
        abilities[aCount].abilityDetails[++bCount] = "         2 seconds max duration";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "The cooldown triggers after the Ability-dva2.png Boosters ability ends.";
        abilities[aCount].abilityDetails[++bCount] = "Cancelled upon using quick melee.";
        abilities[aCount].abilityDetails[++bCount] = "Does not affect Fusion Cannons or Micro Missiles' accuracy.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "MICRO MISSILES";
        abilities[aCount].abilityDescription = "D.Va launches a volley of explosive rockets.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MicroMissiles";
        abilities[aCount].abilityVideo = hero + "/ability-micro-missiles";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:Direct hit: 7 per missile";
        abilities[aCount].abilityDetails[++bCount] = "         Splash: 1 - 4 per missile";
        abilities[aCount].abilityDetails[++bCount] = "         Self: 1 - 4 per missile";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:40 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:1.5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:11 missiles per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:18";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.25 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Deals up to 126 total damage. (8.18% ultimate charge)";
        abilities[aCount].abilityDetails[++bCount] = "Can be used alongside Ability-dva1.png Fusion Cannons.";
        abilities[aCount].abilityDetails[++bCount] = "Cannot be manually cancelled.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SELF - DESTRUCT";
        abilities[aCount].abilityDescription = "D.Va ejects from her mech and sets its reactor to explode, dealing massive damage to nearby opponents";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SelfDestruct";
        abilities[aCount].abilityVideo = hero + "/ability-self-destruct";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:100 - 1000";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:20 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:3-second fuse";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1540 points";
        abilities[aCount].abilityDetails[++bCount] = "The detonating mech retains the momentum from Boosters.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EJECT!";
        abilities[aCount].abilityDescription = "D.Va's mech will automatically eject her when it reaches 1 Health. This forces D.Va into Pilot Form.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Eject";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[4];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:150 health";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:1.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "D.Va can use Self-Destruct while ejecting.";
        abilities[aCount].abilityDetails[++bCount] = "D.Va is invulnerable while ejecting.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CALL MECH";
        abilities[aCount].abilityDescription = "If her armored battle suit is destroyed, D.Va can call down a fresh mech and return to the fray.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CallMech";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:300 health";
        abilities[aCount].abilityDetails[++bCount] = "         300 armor";
        abilities[aCount].abilityDetails[++bCount] = "Damage:250";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:2.5 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.91 seconds for damage + 0.1 for sit in mech + 2 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:319.2 points";
        abilities[aCount].abilityDetails[++bCount] = "Becomes completely charged after Ability-dva4.png Self-Destruct detonates, or if D.Va is Ability-mercy5.png Resurrected.";
        abilities[aCount].abilityDetails[++bCount] = "Automatically reloads the Ability-dva5.png Light Gun.";

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