using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassidyHD : HeroData
{
    public CassidyHD() : base()
    {
        this.hero = HERO_ID.Cassidy;
        this.health = 225;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Armed with his Peacekeeper revolver, Cassidy takes out targets with deadeye precision and dives out of danger with eagle-like speed.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PEACEKEEPER";
        abilities[aCount].abilityDescription = "Accurate, powerful revolver.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PeaceKeeper";
        abilities[aCount].abilityVideo = hero + "/ability-peacekeeper";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:21 - 70";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:20 to 40 meters";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:0.5 second recovery 2 shots per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:6";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "After the shot, the game raises the Cassidy camera (changes the facing angle) by 4 units, after which it starts lowering the character's camera to its previous value. As soon as this happens cassidy can shoot again.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FAN THE HAMMER";
        abilities[aCount].abilityDescription = "Cassidy can fan the Peacekeeper’s hammer to swiftly unload the entire cylinder.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PeaceKeeper";
        abilities[aCount].abilityVideo = hero + "/ability-peacekeeper";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:15 - 50";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:20 to 40 meters";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Constant: 6.50 degrees";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 shot per 0.13 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:6";
        abilities[aCount].abilityDetails[++bCount] = "Ammo usage:up to 6";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Each shot raises the Cassidy camera (changes the facing angle) by 2.5 units.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "COMBAT ROLL";
        abilities[aCount].abilityDescription = "Cassidy dives in the direction he’s moving, effortlessly reloading his Peacekeeper in the process.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CombatRoll";
        abilities[aCount].abilityVideo = hero + "/ability-combat-roll";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:15 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:~6 meters";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Can be used while airborne.";
        abilities[aCount].abilityDetails[++bCount] = "Travels in the direction Cassidy is walking, not the direction he is facing (unless he is not moving).";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FLASHBANG";
        abilities[aCount].abilityDescription = "Cassidy heaves a blinding grenade that explodes shortly after it leaves his hand. The blast staggers enemies in a small radius.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FlashBang";
        abilities[aCount].abilityVideo = hero + "/ability-flashbang";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:25";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:30 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:7 meters";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:3 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.35 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "             0.65 seconds before cooldown starts";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.8 second stun";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Flashbang can affect enemies up to 10 m away.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEADEYE";
        abilities[aCount].abilityDescription = "Focus. Mark. Draw. Cassidy takes a few precious moments to aim; when he’s ready to fire, he shoots every enemy in his line of sight. The weaker his targets are, the faster he’ll line up a killshot.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DeadEye";
        abilities[aCount].abilityVideo = hero + "/ability-deadeye";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:0.2 to 1.0 seconds: 100 per second; 80 overall";
        abilities[aCount].abilityDetails[++bCount] = "         1.0 to 1.5 seconds: 275 per second";
        abilities[aCount].abilityDetails[++bCount] = "         After 1.5 seconds: 550 per second";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-70% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:200 meters";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 shot per 0.2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ammo usage:1 per target";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.29 s. min. duration";
        abilities[aCount].abilityDetails[++bCount] = "         6.2 s. max. duration";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1680 points";
        abilities[aCount].abilityDetails[++bCount] = "If the accumulated damage is above an enemy's health, a skull will appear.";

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