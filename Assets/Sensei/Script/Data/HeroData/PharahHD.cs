using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PharahHD : HeroData
{
    public PharahHD() : base()
    {
        this.hero = HERO_ID.Pharah;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Soaring through the air in her combat armor, and armed with a launcher that lays down high-explosive rockets, Pharah is a force to be reckoned with.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ROCKET LAUNCHER";
        abilities[aCount].abilityDescription = "Pharah's primary weapon launches rockets that deal significant damage in a wide blast radius.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-launcher";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Direct hit: 120\n              Explosion: ~24.6 - 80\n              Self: ~12.3 - 40";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 35 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 2.5 meter radius (explosion)\n             0.2 meter radius(projectile)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 shot per 0.85 seconds\n             extra delay while using meleee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 6";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nExplosive Damage and knockback decreases with distance from the explosion, reaching 0% at the edge of the blast radius.";
        abilities[aCount].abilityDetails[++bCount] = "\nExplosive Damage and knockback also applies to self.";
        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "HOVER JETS";
        abilities[aCount].abilityDescription = "Hold to hover.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HoverJets";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> +20% buff\n          4.27 meters per second (vertically)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Up to 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nActivated by holding jump button while in the air, or alt-fire button.";
        abilities[aCount].abilityDetails[++bCount] = "\nAllows Pharah to gain height when held. When held for 2 seconds, Pharah gains more than 8 meters vertical height.";
        abilities[aCount].abilityDetails[++bCount] = "\nRefuels 43% per second automatically when not in use, taking ~2.33 seconds to refill from empty to full.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe red portion of Pharah's fuel bar signifies the area that will not be refueled by the time Pharah reaches the peak of her Jump Jet.";
        abilities[aCount].abilityDetails[++bCount] = "\nAllows Pharah to hover indefinitely when paired with Jump Jet.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CONCUSSIVE BLAST";
        abilities[aCount].abilityDescription = "Pharah looses a wrist rocket that knocks back any enemies it strikes.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConcussiveBlast";
        abilities[aCount].abilityVideo = hero + "/ability-concussive-blast";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Knockback";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 60 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 8 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.16 seconds for throw + 0.5 seconds recovery for shoot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 9 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nDuring cast time, you can change the future flight path.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the ability is interrupted before the end of the casting time, the cooldown will not start.";
        abilities[aCount].abilityDetails[++bCount] = "\nAlso knocks back Pharah herself.";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be used as an additional mobility tool, as it does not deal self damage.";
        abilities[aCount].abilityDetails[++bCount] = "\nMostly deals horizontal knockback.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "JUMP JET";
        abilities[aCount].abilityDescription = "Propelled by her suit's thrusters, Pharah soars high into the air.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/JumpJet";
        abilities[aCount].abilityVideo = hero + "/ability-jump-jet";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Max Range:</b> 11.55 meters vertically";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 0.496 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "This combo will allow you to fly up to 22 meters:\n    Use ability 2, wait 0.160 seconds, use ability 1 and start holding jump.";
        abilities[aCount].abilityDetails[++bCount] = "This combo will allow you to fly up to 32 meters:\n    Use primary fire, wait 0.048 seconds, use ability 1 and start holding jump.";
        abilities[aCount].abilityDetails[++bCount] = "This combo will allow you to fly up to 40 meters:\n    Use primary fire, wait 0.048 seconds, use ability 1 & 2 and start holding jump.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe stun does not interrupt the ability.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BARRAGE";
        abilities[aCount].abilityDescription = "Pharah directs a continuous salvo of mini-rockets to destroy groups of enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Barrage";
        abilities[aCount].abilityVideo = hero + "/ability-barrage";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Direct hit: 40\n       Splash: 9 - 30\n       Self: 4.5 - 15";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> Caster immobilized";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 45 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 2 meter explosion radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 30 rockets per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 2.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2100 points";
        abilities[aCount].abilityDetails[++bCount] = "\nPharah remains stationary while the ability is active, but can turn.";
        abilities[aCount].abilityDetails[++bCount] = "\nPharah will stay in the air if the ability is used mid-air.";
        abilities[aCount].abilityDetails[++bCount] = "\nRestores Rocket Launcher ammo after the ability ends, provided the ability wasn't canceled prematurely.";
        abilities[aCount].abilityDetails[++bCount] = "\nA total of 675 - 3000 damage can be dealt to enemies using the ultimate.";
        abilities[aCount].abilityDetails[++bCount] = "\nA total of 337.5 - 1125 self-damage can be dealt through the ultimate.";

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