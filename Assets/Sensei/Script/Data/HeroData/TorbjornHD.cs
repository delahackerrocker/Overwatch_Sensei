using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorbjornHD : HeroData
{
    public TorbjornHD() : base()
    {
        this.hero = HERO_ID.Torbjorn;
        this.health = 200;
        this.shields = 0;
        this.armor = 50;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "";
        stars = 2;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "RIVET GUN";
        abilities[aCount].abilityDescription = "Slow firing, long-ranged weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RivetGun";
        abilities[aCount].abilityVideo = hero + "/ability-rivet-gun";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 70 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 70 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "              0.6 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "              ~1.67 shots per second";
        abilities[aCount].abilityDetails[++bCount] = "              extra delay while using melee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 18";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 2 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nAutomatically reloaded if Torbj?rn has his Forge Hammer equipped for 2 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nTurret will target enemy hit by primary fire if within range and line of sight.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RIVET GUN - ALT FIRE";
        abilities[aCount].abilityDescription = "Torbj?rn ejects molten metal from his gun in a short, close-range burst.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RivetGun";
        abilities[aCount].abilityVideo = hero + "/ability-rivet-gun";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 3.75 - 12.5 per pellet\n        37.5 - 125 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 10 to 20 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Constant: 4.15 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 120 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> 10";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 0.8 second recovery\n          1.25 shots per second\n          extra delay while using meleee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 18";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 3 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 2 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FORGE HAMMER";
        abilities[aCount].abilityDescription = "This multipurpose hammer repairs turrets and, in a pinch, can also be used as a weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ForgeHammer";
        abilities[aCount].abilityVideo = hero + "/ability-forge-hammer";
        abilities[aCount].controllerButton = ControllerButton.DPadLeft;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 55";
        abilities[aCount].abilityDetails[++bCount] = "<b>Healing:</b> 50 (to Torbj?rn's turret)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 2.5 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 swing per 0.848 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.352 second (initial swing)\n          0.192 second (dealing damage)\n          0.304 second(recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nUpon switching weapon, there is 0.51 second recovery period where Torbjorn cannot use his weapon.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "OVERLOAD";
        abilities[aCount].abilityDescription = "Torbj?rn gains additional armor as well as improved attack, movement, and reload speed for a brief period.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Overload";
        abilities[aCount].abilityVideo = hero + "/ability-overload";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> +100 armor";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +30% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> ";
        abilities[aCount].abilityDetails[++bCount] = "            Rivet Gun: 0.42 second recovery (primary fire), 0.56 second recovery (alternate fire)";
        abilities[aCount].abilityDetails[++bCount] = "            Forge Hammer: 0.62 second recovery, 0.24 seconds before initial swing";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.4 seconds (Rivet Gun)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.69 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nIncreases Rivet Gun's fire rate and reload speed by ~43%.";
        abilities[aCount].abilityDetails[++bCount] = "\nIncreases Forge Hammer's swing rate by ~37% and decreases the initial swing time by 0.11 seconds.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEPLOY TURRET";
        abilities[aCount].abilityDescription = "Torbj?rn deploys a self-building turret which automatically tracks and attacks enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DeployTurret";
        abilities[aCount].abilityVideo = hero + "/ability-deploy-turret";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[14];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 250";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 14 per 0.256 seconds\n        (56 per second)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 17 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 15 meters (deploying turret)\n          40 meters(attack range)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 4 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 3 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Until destroyed";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 5 seconds\n          10 seconds if destroyed while in combat";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nTurret deploy can be thrown to a maximum distance of 15 meters on ground level.";
        abilities[aCount].abilityDetails[++bCount] = "\nTurret automatically attacks the closest enemy within line of slight and continues attacking that enemy until it is either dead or out of sight.";
        abilities[aCount].abilityDetails[++bCount] = " - Target can be changed if the player damages said enemy with Rivet Gun's primary fire.";
        abilities[aCount].abilityDetails[++bCount] = "\nTurret cannot be redeployed if it dealt or received damage within the last 3 seconds. The Deploy Turret key will appear colored to indicate this.";
        abilities[aCount].abilityDetails[++bCount] = " - If the Turret is destroyed during this time, including by the Interact key, Deploy Turret will go on a 10 second cooldown.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "MOLTEN CORE";
        abilities[aCount].abilityDescription = "Torbj?rn creates pools of molten slag that deal massive, sustained damage (plus bonus damage to armor), and can prevent enemies from moving through key locations.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MoltenCore";
        abilities[aCount].abilityVideo = hero + "/ability-molten-core";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Impact: 25\n          Pools: 160 per second, +90 against armor";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 40 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 2.5 meter interact radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> ";
        abilities[aCount].abilityDetails[++bCount] = "  1 ammo per 0.144 (if holding primary)\n  1 ammo per 0.016(if spaming primary enough fast)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 10";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.77 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Up to 5.5 seconds (claw)\n          10 seconds(pools)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2142 points";
        abilities[aCount].abilityDetails[++bCount] = "\norbj?rn's weapon is temporarily replaced by his claw, which shoots out molten slags.";
        abilities[aCount].abilityDetails[++bCount] = "\nEach shot will bounce until it hits the floor, at which point it will turn into a pool that deals damage over time.";
        abilities[aCount].abilityDetails[++bCount] = "\nAgainst armor, the pools deal 250 damage per second.";
        abilities[aCount].abilityDetails[++bCount] = "\nDamage from pools do not stack: two pools in the same area deal the same damage as one pool.";

        strongAgainst = new HERO_ID[5];
        strongAgainst[0] = HERO_ID.Tracer;
        strongAgainst[1] = HERO_ID.Reinhardt;
        strongAgainst[2] = HERO_ID.Winston;
        strongAgainst[3] = HERO_ID.WreckingBall;
        strongAgainst[4] = HERO_ID.Brigitte;

        weakAgainst = new HERO_ID[8];
        weakAgainst[0] = HERO_ID.Ana;
        weakAgainst[1] = HERO_ID.Ashe;
        weakAgainst[2] = HERO_ID.Baptiste;
        weakAgainst[3] = HERO_ID.Roadhog;
        weakAgainst[4] = HERO_ID.Reaper;
        weakAgainst[5] = HERO_ID.Hanzo;
        weakAgainst[6] = HERO_ID.Pharah;
        weakAgainst[7] = HERO_ID.Soldier76;
    }
}