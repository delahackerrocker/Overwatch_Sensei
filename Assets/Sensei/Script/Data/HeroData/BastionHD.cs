using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BastionHD : HeroData
{
    public BastionHD() : base()
    {
        this.hero = HERO_ID.Bastion;
        this.health = 200;
        this.shields = 0;
        this.armor = 100;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Repair protocols and the ability to transform between stationary Assault, mobile Recon and devastating Tank configurations provide Bastion with a high probability of victory.";
        stars = 1;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "CONFIGURATION:\nRECON";
        abilities[aCount].abilityDescription = "In Recon mode, Bastion is fully mobile, outfitted with a submachine gun that fires steady bursts of bullets at medium range.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConfigurationSentry";
        abilities[aCount].abilityVideo = hero + "/ability-configuration-recon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 6 - 20";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 25 to 45 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Max: 1.2";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 8 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 35";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SELF-REPAIR";
        abilities[aCount].abilityDescription = "Bastion restores its health; it cannot fire weapons while the repair process is in effect.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SelfRepair";
        abilities[aCount].abilityVideo = hero + "/ability-self-repair";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> 90 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.5 second delay";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Up to 3.33 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 1 second";
        abilities[aCount].abilityDetails[++bCount] = "\nBastion cannot activate Self-Repair when the resource meter is below 20%.";
        abilities[aCount].abilityDetails[++bCount] = "\nTakes 7 seconds to fully recharge.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RECONFIGURE";
        abilities[aCount].abilityDescription = "Switch between weapon configurations.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Reconfigure";
        abilities[aCount].abilityVideo = hero + "/ability-reconfigure";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Casting Time:</b> 1 second (into Sentry)";
        abilities[aCount].abilityDetails[++bCount] = "                0.5 seconds (into Recon)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> None";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CONFIGURATION:\nSentry";
        abilities[aCount].abilityDescription = "In Sentry mode, Bastion is a stationary powerhouse equipped with a gatling gun capable of unleashing a hail of bullets. The gun's aim can be 'walked' across multiple targets, dealing devastating damage at short to medium range.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConfigurationSentry";
        abilities[aCount].abilityVideo = hero + "/ability-configuration-sentry";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 4.5 - 15";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 30 to 50 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> 1.8 - 2.7 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> 0";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 30 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 300";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.984 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nMakes Bastion immune to knock-back effects and Orisa's Ability Orisa Halt!.png Halt!.";
        abilities[aCount].abilityDetails[++bCount] = "\nBastion has a glowing blue box on its back that can be hit for headshot damage.";
        abilities[aCount].abilityDetails[++bCount] = "\nBastion comes out of Configuration: Sentry if it is Hacked, Slept, Pinned, Hooked, or knocked down.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CONFIGURATION:\nTANK";
        abilities[aCount].abilityDescription = "In Tank mode, Bastion extends wheeled treads and a powerful long-range cannon. The cannon’s explosive shells demolish targets in a wide blast radius, but Bastion can only remain in this mode for a limited time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConfigurationTank";
        abilities[aCount].abilityVideo = hero + "/ability-configuration-tank";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Direct hit: 205";
        abilities[aCount].abilityDetails[++bCount] = "         Splash: 42 - 140";
        abilities[aCount].abilityDetails[++bCount] = "         Self: 10.5 - 35 (becomes 8.4 - 28 due to Ironclad)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 60 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 4 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 shot per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> infinite";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2310 points";
        abilities[aCount].abilityDetails[++bCount] = "\nBastion cannot receive headshots as both its head and its blue box are covered.";
        abilities[aCount].abilityDetails[++bCount] = "\nAmmunition of Configuration: Recon is immediately restored upon activation.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "IRONCLAD";
        abilities[aCount].abilityDescription = "Reduces damage taken while transformed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/IronClad";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Dmg. Reduction:</b> 20%";
        abilities[aCount].abilityDetails[++bCount] = "\nApplies to configurations Sentry and Tank upon their complete transformation.";
        abilities[aCount].abilityDetails[++bCount] = "\nDamage reduction is applied before armor.";

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