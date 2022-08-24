using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrisaHD : HeroData
{
    public OrisaHD() : base()
    {
        this.hero = HERO_ID.Orisa;
        this.health = 200;
        this.shields = 0;
        this.armor = 250;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "FUSION DRIVER";
        abilities[aCount].abilityDescription = "Orisa’s automatic projectile cannon delivers sustained damage, but slows her movement while she fires it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FusionDriver";
        abilities[aCount].abilityVideo = hero + "/ability-fusion-driver";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:11";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Constant: 1.2 degree";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-30% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:120 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:12 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:150";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:2.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PROTECTIVE BARRIER";
        abilities[aCount].abilityDescription = "Throw a device that creates a barrier.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ProtectiveBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-protective-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Orisa throws out a stationary barrier that can protect her and her allies from enemy fire.";
        abilities[aCount].abilityDetails[++bCount] = "Health:600";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Duration:20 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown begins immediately.";
        abilities[aCount].abilityDetails[++bCount] = "The projectile ignores Defense Matrix, Deflect, and Kinetic Grasp.";
        abilities[aCount].abilityDetails[++bCount] = "The barrier is shaped like a football net.";
        abilities[aCount].abilityDetails[++bCount] = "The barrier extends slightly below where it is deployed in the case that it is on a ledge or a payload.";
        abilities[aCount].abilityDetails[++bCount] = "The barrier can be deployed without interrupting Fusion Driver's reload.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FORTIFY";
        abilities[aCount].abilityDescription = "Orisa temporarily reduces damage she takes and cannot be affected by movement-impairing effects.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Fortify";
        abilities[aCount].abilityVideo = hero + "/ability-fortify";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Dmg. reduction:40%";
        abilities[aCount].abilityDetails[++bCount] = "Duration:4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "risa takes no headshot damage.";
        abilities[aCount].abilityDetails[++bCount] = "Orisa becomes immune to all movement-related Crowd Control effects, including stun, sleep, freeze, pin, knock down, knock back, pull, slow, root, etc.";
        abilities[aCount].abilityDetails[++bCount] = "Orisa can escape Steel Trap, Graviton Surge, and Gravitic Flux.";
        abilities[aCount].abilityDetails[++bCount] = "Orisa takes no damage from Charge or Chain Hook.";
        abilities[aCount].abilityDetails[++bCount] = "Orisa can be hacked by Sombra while using Fortify, but this will not interrupt the ability.";
        abilities[aCount].abilityDetails[++bCount] = "Allies behind Orisa are not protected from abilities such as Earthshatter or RIP-Tire.";
        abilities[aCount].abilityDetails[++bCount] = "Armor is applied after damage reduction. Attacks consisting of 16.667... or lower damage (e.g. Sombra's Ability Sombra Machine Pistol.png Machine Pistol) are reduced by 70%. Beams are reduced by 58%.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "HALT!";
        abilities[aCount].abilityDescription = "Launch a graviton charge which can be detonated with the same action. The sphere slows and pulls nearby enemies to it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Halt";
        abilities[aCount].abilityVideo = hero + "/ability-halt";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:20 meters per second (pull speed)";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.1 seconds (launch)\n            0.45 seconds(activation)";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.65 seconds (snare)";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Automatically activates upon touching a surface.";
        abilities[aCount].abilityDetails[++bCount] = "Can be manually activated by pressing the key/button again.";
        abilities[aCount].abilityDetails[++bCount] = "Enemies in range are pulled to the center and are briefly slowed until 0.65 seconds after activation.";
        abilities[aCount].abilityDetails[++bCount] = "The projectile itself goes through barriers, but the pull effect is blocked by them.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SUPERCHARGER";
        abilities[aCount].abilityDescription = "Orisa deploys a device to increase damage inflicted by allies within her line of sight.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SuperCharger";
        abilities[aCount].abilityVideo = hero + "/ability-supercharger";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:200";
        abilities[aCount].abilityDetails[++bCount] = "Damage:+50% damage boost";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:7 meters per second (horizontal)";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:25 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.4 seconds (spawning Supercharger projectile)";
        abilities[aCount].abilityDetails[++bCount] = "Duration:15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1680 points";
        abilities[aCount].abilityDetails[++bCount] = "Orisa passively generates 1% Ult Charge every 3.36 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "Enemy barriers break line of sight.";
        abilities[aCount].abilityDetails[++bCount] = "The effect lingers for 1 second if line of sight is broken or if a player is out of range.";
        abilities[aCount].abilityDetails[++bCount] = "Can be Ability Sombra Hack.png hacked by Sombra, which disables it for 10 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "The Supercharger projectile experiences 3x normal gravity (60 meters per second squared)";

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