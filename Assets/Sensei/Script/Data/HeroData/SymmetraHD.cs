using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymmetraHD : HeroData
{
    public SymmetraHD() : base()
    {
        this.hero = HERO_ID.Symmetra;
        this.health = 100;
        this.shields = 125;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Symmetra utilizes her Photon Projector to dispatch adversaries, shield her associates, construct teleportation pads and deploy particle-blasting Sentry Turrets.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PHOTON PROJECTOR";
        abilities[aCount].abilityDescription = "Symmetra?s weapon emits a ranged beam. It deals continuous damage that increases the longer it is connected.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Symmetra";
        abilities[aCount].abilityVideo = hero + "/ability-photon-projector";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 60/120/180 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 12 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.2 meter beam width";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 70";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 7 per second";
        abilities[aCount].abilityDetails[++bCount] = "+7 per second gained against barriers";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly starts charge + 0.11 s. recovery for reuse";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nLevels up by hitting an enemy or an enemy object (e.g. barrier, turret, mine, etc.) for 1.33 seconds. If the beam is not hitting anything, it decays from level 3 to level 2 in 4.0 seconds and from level 2 to level 1 in 2.0 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nGenerates ammo instead of consuming it when attacking barriers. ";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PHOTON PROJECTOR";
        abilities[aCount].abilityDescription = "The projector can also release an explosive energy ball that deals high damage on contact.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Symmetra";
        abilities[aCount].abilityVideo = hero + "/ability-photon-projector";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Direct hit: 120 (full charge)";
        abilities[aCount].abilityDetails[++bCount] = "                       Splash: 15-60 (full charge)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 2 meter radius (explosion)";
        abilities[aCount].abilityDetails[++bCount] = "               0.5 meter radius (projectile max charge)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 9 rounds per second while charging (max. 9)";
        abilities[aCount].abilityDetails[++bCount] = "             0.25 second recovery for shoot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 70";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 1-10 rounds based on charge time";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nTakes 1 second to fully charge and can be held for 1 second.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TELEPORTER";
        abilities[aCount].abilityDescription = "Symmetra places a temporary teleporter exit pad at a distance and connects it to a teleporter entry pad at her current location. Allies (and some of their abilities, such as Junkrat?s RIP-Tire) can travel from the entry pad to the exit pad instantly.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Teleporter";
        abilities[aCount].abilityVideo = hero + "/ability-teleporter";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 50 health";
        abilities[aCount].abilityDetails[++bCount] = "           250 shields";
        abilities[aCount].abilityDetails[++bCount] = "<b>Healing:</b> Regenerates 30 shields per second, after avoiding damage for 3 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 30 meters (placement)";
        abilities[aCount].abilityDetails[++bCount] = "           40 meters (max. absolute range)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 1.5 meter (interact range)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1.5 seconds (deployment)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Infinite";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nRequires the player to use the Interact key to activate, unless it's an entity separate from a player, in which case it will teleport automatically. (Turrets, D.Va's MEKA when self-destructing, etc)";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the entrance and exit are more than 40 meters apart, they are automatically destroyed.";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be manually destroyed by pressing the ability key again, including while dead.";
        abilities[aCount].abilityDetails[++bCount] = "\nCannot be used while in spawn.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SENTRY TURRET";
        abilities[aCount].abilityDescription = "Symmetra launches a small turret that automatically fires speed-reducing blasts at the nearest enemy within range. Up to three turrets can be built on the battlefield at once.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SentryTurret";
        abilities[aCount].abilityVideo = hero + "/ability-sentry-turret";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[14];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 30";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 40 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> ?20% (slow)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 15 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 10 meters (turret beam)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 3 stored";
        abilities[aCount].abilityDetails[++bCount] = "     Max 3 on the field";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.22 seconds for throw + 0.28 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds per charge";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the ability throw is interrupted, the charge will not be spent.";
        abilities[aCount].abilityDetails[++bCount] = "\nTurrets are projectiles until they hit a wall, at which point they will deploy.";
        abilities[aCount].abilityDetails[++bCount] = "\nWhile in the air, Sentry Turrets cannot attack but can still be destroyed. They pass through enemy barriers.";
        abilities[aCount].abilityDetails[++bCount] = "\nUnaffected by Defense Matrix, Deflect, or Kinetic Grasp.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PHOTON BARRIER";
        abilities[aCount].abilityDescription = "Symmetra deploys a massive energy barrier which prevents ranged attacks and is big enough to cut through the entire map.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PhotonBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-photon-barrier";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 4000";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 25 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> Entire map (~484 m ? 50 m)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1680 points";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be placed from anywhere (including from the spawn room), since it covers the entire map.";
        abilities[aCount].abilityDetails[++bCount] = "\nOrientation can be changed by pressing the Ultimate key again (like Mei's Ice Wall).";

        strongAgainst = new HERO_ID[4];
        strongAgainst[0] = HERO_ID.Orisa;
        strongAgainst[1] = HERO_ID.Reinhardt;
        strongAgainst[2] = HERO_ID.Sigma;
        strongAgainst[3] = HERO_ID.Brigitte;

        weakAgainst = new HERO_ID[5];
        weakAgainst[0] = HERO_ID.Cassidy;
        weakAgainst[1] = HERO_ID.Pharah;
        weakAgainst[2] = HERO_ID.Widowmaker;
        weakAgainst[3] = HERO_ID.Winston;
        weakAgainst[4] = HERO_ID.Sombra;
    }
}