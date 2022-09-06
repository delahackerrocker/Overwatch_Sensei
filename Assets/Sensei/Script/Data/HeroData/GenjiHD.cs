using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenjiHD : HeroData
{
    public GenjiHD() : base()
    {
        this.hero = HERO_ID.Genji;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Genji flings precise and deadly Shuriken at his targets, and uses his technologically-advanced katana to deflect projectiles or deliver a Swift Strike that cuts down enemies.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "SHURIKEN";
        abilities[aCount].abilityDescription = "Throw an accurate burst of 3 projectiles.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Shuriken";
        abilities[aCount].abilityVideo = hero + "/ability-shuriken";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 29";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 60 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.1 meters shiruken radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 3 shurikens per 0.88 seconds";
        abilities[aCount].abilityDetails[++bCount] = "             extra delay while using meleee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 30";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FAN OF BLADES";
        abilities[aCount].abilityDescription = "Throw a fan of 3 projectiles in an arc.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Shuriken";
        abilities[aCount].abilityVideo = hero + "/ability-shuriken";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 29";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> 9";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 60 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.1 meters shiruken radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 3 shurikens per 0.68 second";
        abilities[aCount].abilityDetails[++bCount] = "             extra delay while using meleee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 30";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 3";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DEFLECT";
        abilities[aCount].abilityDescription = "With lightning-quick swipes of his wakizashi, Genji reflects an oncoming projectile and sends it rebounding towards his opponent.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Deflect";
        abilities[aCount].abilityVideo = hero + "/ability-deflect";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Area of Effect:</b> 1 meter radius (front only)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.192 s. recovery for shoot after end";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be cancelled manually.";
        abilities[aCount].abilityDetails[++bCount] = "\nAny projectile deflected is treated as Genji's, and damage falloff is reset.";
        abilities[aCount].abilityDetails[++bCount] = "\nBlocks melee attacks, Chain Hook, and Whip Shot.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SWIFT STRIKE";
        abilities[aCount].abilityDescription = "Genji darts forward, slashing with his wakizashi and passing through foes in his path. If Genji eliminates a target, he can instantly use this ability again.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SwiftStrike";
        abilities[aCount].abilityVideo = hero + "/ability-swift-strike";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 50";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> 50 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 15 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 0.4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nThe cooldown will reset no matter what ability is used for the kill.";
        abilities[aCount].abilityDetails[++bCount] = "\nSwift Strike does not deal damage to traps such as Junkrat's Steel Trap or Widowmaker's Venom Mine.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "DRAGON BLADE";
        abilities[aCount].abilityDescription = "Genji brandishes his katana for a brief period of time. Until he sheathes his katana, Genji can deliver killing strikes to any targets within his reach.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/DragonBlade";
        abilities[aCount].abilityVideo = hero + "/ability-dragonblade";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 110";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +30% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 5 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 swing per 0.9 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1 second (unsheathing)";
        abilities[aCount].abilityDetails[++bCount] = "             0.224 seconds (initial swing)";
        abilities[aCount].abilityDetails[++bCount] = "             1 second (sheathing)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1932 points";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CYBER AGILITY";
        abilities[aCount].abilityDescription = "Climb on walls and double jump.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CyberAgility";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> 7.8 meters per second (vertical)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Up to 1 second";
        abilities[aCount].abilityDetails[++bCount] = "\nDouble jumping doesn't reset on wall climbing.";

        strongAgainst = new HERO_ID[8];
        strongAgainst[0] = HERO_ID.Ana;
        strongAgainst[1] = HERO_ID.Ashe;
        strongAgainst[2] = HERO_ID.Hanzo;
        strongAgainst[3] = HERO_ID.Bastion;
        strongAgainst[4] = HERO_ID.Junkrat;
        strongAgainst[5] = HERO_ID.Orisa;
        strongAgainst[6] = HERO_ID.Torbjorn;
        strongAgainst[7] = HERO_ID.Zenyatta;

        weakAgainst = new HERO_ID[8];
        weakAgainst[0] = HERO_ID.Brigitte;
        weakAgainst[1] = HERO_ID.Pharah;
        weakAgainst[2] = HERO_ID.Moira;
        weakAgainst[3] = HERO_ID.Doomfist;
        weakAgainst[4] = HERO_ID.Winston;
        weakAgainst[5] = HERO_ID.Mei;
        weakAgainst[6] = HERO_ID.Zarya;
        weakAgainst[7] = HERO_ID.Moira;
    }
}