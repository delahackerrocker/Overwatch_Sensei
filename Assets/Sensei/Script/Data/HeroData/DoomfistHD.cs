using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomfistHD : HeroData
{
    public DoomfistHD() : base()
    {
        this.hero = HERO_ID.Doomfist;
        this.health = 250;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Doomfist’s cybernetics make him a highly-mobile, powerful frontline fighter. In addition to dealing ranged damage with his Hand Cannon, Doomfist can slam the ground, knock enemies into the air and off balance, or charge into the fray with his Rocket Punch. When facing a tightly packed group, Doomfist leaps out of view, then crashes down to earth with a spectacular Meteor Strike.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HAND CANNON";
        abilities[aCount].abilityDescription = "Doomfist fires a short-range burst from the knuckles of his fist. Its ammunition is automatically regenerated over a short time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HandCannon";
        abilities[aCount].abilityVideo = hero + "/ability-hand-cannon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:1.8 - 6 per pellet";
        abilities[aCount].abilityDetails[++bCount] = "           19.8 - 66 per shot";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:15 meters to 30 meters";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Constant: 2.15 degrees";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:80 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Num. of pellets:11 per shot";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 shot per 0.32 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:4";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:0.32 seconds (inital reload)";
        abilities[aCount].abilityDetails[++bCount] = "            +0.65 second (per bullet)";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Unlike most weapons, Hand Cannon cannot be forced to reload by using the 'Reload' key.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SEISMIC SLAM";
        abilities[aCount].abilityDescription = "Doomfist leaps forward and smashes into the ground, knocking nearby enemies toward him.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SeismicSlam";
        abilities[aCount].abilityVideo = hero + "/ability-seismic-slam";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:25 - 125";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:25 meters per second (diagonal)";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:15 meters (travel distance)";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:8 meters";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Damage scales with the time spent in air during the slam, up to a maximum of 125.";
        abilities[aCount].abilityDetails[++bCount] = "While airborne, a blue, arc-shaped indicator will show where the ability will land. The orientation of the slam can be changed in the air.";
        abilities[aCount].abilityDetails[++bCount] = "On flat ground, Seismic Slam horizontally propels Doomfist 8.22 meters and deals 49 damage. Adding a jump can increase this damage to 62.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RISING UPPERCUT";
        abilities[aCount].abilityDescription = "Doomfist uppercuts enemies in front of him into the air.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RisingUppercut";
        abilities[aCount].abilityVideo = hero + "/ability-rising-uppercut";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:50";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:10 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:5 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.35 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.6 seconds (air lock)";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Enemies knocked into the air lose air control for 0.6 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "Doomfist is briefly suspended in the air after the uppercut, slowing his fall speed.";
        abilities[aCount].abilityDetails[++bCount] = "This ability is removed in Overwatch 2.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ROCKET PUNCH";
        abilities[aCount].abilityDescription = "After charging up, Doomfist lunges forward and knocks an enemy back, dealing additional damage if they impact a wall.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketPunch";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-punch";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[16];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:50 - 100 (punch)";
        abilities[aCount].abilityDetails[++bCount] = "          50 - 150 (wall impact)";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-50% penalty (charging)";
        abilities[aCount].abilityDetails[++bCount] = "            45 meters per second (punch)";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:~6.4 to 20 meters (depending on charge)";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.192 min. charge time";
        abilities[aCount].abilityDetails[++bCount] = "               1.4 seconds to fully charge";
        abilities[aCount].abilityDetails[++bCount] = "               2 second max. charge time";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.5 second stun";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Damage, distance traveled, and knock back all scale with the charge time.";
        abilities[aCount].abilityDetails[++bCount] = "It takes ~0.93 seconds of charging in order to kill a 200 HP target, assuming wall impact. This translates to about 2.67 bars of charge in the HUD.";
        abilities[aCount].abilityDetails[++bCount] = "Rocket Punch stops if it hits an enemy.";
        abilities[aCount].abilityDetails[++bCount] = "If Rocket Punch collides with Charge, Shield Bash, a charging B.O.B., or another Rocket Punch, both participants get knocked down for 2 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "While charging, Rocket Punch can be cancelled by pressing the Primary Fire button.";
        abilities[aCount].abilityDetails[++bCount] = "After being released, Rocket Punch can still be cancelled with the Jump key. This pushes Doomfist further than what he would have gone without cancelling.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "METEOR STRIKE";
        abilities[aCount].abilityDescription = "Doomfist leaps into the sky, then crashes to the ground, dealing significant damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MeteorStrike";
        abilities[aCount].abilityVideo = hero + "/ability-meteor-strike";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[17];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:Inner ring: 300";
        abilities[aCount].abilityDetails[++bCount] = "                      Outer ring: 15-200";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:2-8 meters";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:16.5 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:Inner ring: 2 meters";
        abilities[aCount].abilityDetails[++bCount] = "               Outer ring: 6 meters";
        abilities[aCount].abilityDetails[++bCount] = "               Overall radius: 8 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 1 sec before can move & duration starts";
        abilities[aCount].abilityDetails[++bCount] = "Duration:Up to 4 seconds for select area";
        abilities[aCount].abilityDetails[++bCount] = "1.5 seconds landing";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1680 points";
        abilities[aCount].abilityDetails[++bCount] = "This ability works even when used inside an interior area and will land in that area unless Doomfist moves outside.";
        abilities[aCount].abilityDetails[++bCount] = "Holding right click enables a birds-eye view of the impact zone, which can also be used to climb up platforms.";
        abilities[aCount].abilityDetails[++bCount] = "The impact zone is only visible to the enemy team once Doomfist is coming down.";
        abilities[aCount].abilityDetails[++bCount] = "Doomfist is completely invincible during this ultimate.";
        abilities[aCount].abilityDetails[++bCount] = "Meteor Strike has two rings that do different damage. If an enemy is touching both rings, the inner ring takes precedence.";
        abilities[aCount].abilityDetails[++bCount] = "Doomfist's other abilities recharge twice as fast while Doomfist is in the air.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "THE BEST DEFENSE...";
        abilities[aCount].abilityDescription = "Dealing damage with abilities creates temporary personal shields.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TheBestDefense";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[4];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:+30 temporary shields per enemy hit with any of the three normal abilities";
        abilities[aCount].abilityDetails[++bCount] = "+75 shields per enemy hit with the ultimate ability";
        abilities[aCount].abilityDetails[++bCount] = "This ability has a statistic card named 'Shields created.'";
        abilities[aCount].abilityDetails[++bCount] = "After 1 second, the shields start decaying at 3 shields per second.";

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