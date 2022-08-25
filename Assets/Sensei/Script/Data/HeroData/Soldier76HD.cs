using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier76HD : HeroData
{
    public Soldier76HD() : base()
    {
        this.hero = HERO_ID.Soldier76;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Armed with cutting-edge weaponry, including an experimental pulse rifle that’s capable of firing spirals of high-powered Helix Rockets, Soldier: 76 has the speed and support know-how of a highly trained warrior.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "HEAVY PULSE RIFLE";
        abilities[aCount].abilityDescription = "Soldier: 76’s rifle remains particularly steady while unloading fully-automatic pulse fire.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HeavyPulseRifle";
        abilities[aCount].abilityVideo = hero + "/ability-heavy-pulse-rifle";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:6 - 20";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:30 to 50 meters";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:9 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:30";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "This weapon has vertical recoil (despite its official description).";
        abilities[aCount].abilityDetails[++bCount] = "Firing in short controlled bursts negates most of the virtical recoil.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "HELIX ROCKETS";
        abilities[aCount].abilityDescription = "Tiny rockets spiral out of Soldier: 76’s Pulse Rifle in a single burst. The rockets’ explosion damages enemies in a small radius.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/HelixRockets";
        abilities[aCount].abilityVideo = hero + "/ability-helix-rockets";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:Direct hit: 120\n        Splash: 40 - 80\n        Self: 20 - 40";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:50 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:3 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.5 s. recovery for primary";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC FIELD";
        abilities[aCount].abilityDescription = "Soldier: 76 plants a biotic emitter on the ground. Its energy projection restores health to 76 and any of his squadmates within the field.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticField";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-field";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:35 per second 35 per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:4.5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.54 seconds (can't be interrupted)";
        abilities[aCount].abilityDetails[++bCount] = "Duration:5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cannot be destroyed.";
        abilities[aCount].abilityDetails[++bCount] = "Multiple fields do not stack.";
        abilities[aCount].abilityDetails[++bCount] = "Healing is only applied to targets within line of sight of the biotic emitter, ignoring enemy barriers.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SPRINT";
        abilities[aCount].abilityDescription = "Whether he needs to evade a firefight or get back into one, Soldier: 76 can rush ahead in a burst of speed. His sprint ends if he takes an action other than charging forward.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Sprint";
        abilities[aCount].abilityVideo = hero + "/ability-sprint";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[5];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:+50% buff";
        abilities[aCount].abilityDetails[++bCount] = "Duration:?";
        abilities[aCount].abilityDetails[++bCount] = "After Sprint is cancelled, there is a 0.3 second recovery period where Soldier: 76 cannot shoot or reload.";
        abilities[aCount].abilityDetails[++bCount] = "Biotic Field can cancel Sprint without the recovery animation.";
        abilities[aCount].abilityDetails[++bCount] = "The activation of the ability can be customized between holding the button and toggling with a single press.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TACTICAL VISOR";
        abilities[aCount].abilityDescription = "Soldier: 76’s pinpoint targeting visor “locks” his aim on the threat closest to his crosshairs. If an enemy leaves his line of sight, Soldier: 76 can quickly switch to another target.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TacticalVisor";
        abilities[aCount].abilityVideo = hero + "/ability-tactical-visor";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "Reload time:0.65 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:1.2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Duration:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:2310 points";
        abilities[aCount].abilityDetails[++bCount] = "Activation of Tactical Visor instantly replenishes Heavy Pulse Rifle's ammo.";
        abilities[aCount].abilityDetails[++bCount] = "Heavy Pulse Rifle's reload time is greatly reduced.";
        abilities[aCount].abilityDetails[++bCount] = "Damage falloff is disabled.";
        abilities[aCount].abilityDetails[++bCount] = "Tactical Visor targets enemy heroes, RIP-Tire, and Immortality Field.";
        abilities[aCount].abilityDetails[++bCount] = "Soldier: 76 cannot headshot while Tactical Visor is active.";
        abilities[aCount].abilityDetails[++bCount] = "Soldier: 76 will only lock on to a target if their center of mass is visible and not behind an enemy barrier";
        abilities[aCount].abilityDetails[++bCount] = "The aim lock does not apply to Icon-ability.helixrockets.png Helix Rockets.";

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