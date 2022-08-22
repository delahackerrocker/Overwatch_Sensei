using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaptisteHD : HeroData
{
    public BaptisteHD() : base()
    {
        this.hero = HERO_ID.Baptiste;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        description = "Baptiste wields an assortment of experimental devices and weaponry to keep allies alive and eliminate threats under fierce conditions. A battle-hardened combat medic, he is just as capable of saving lives as he is taking out the enemy.";
        stars = 3;

        int aCount = 0;
        int bCount = 0;

        abilities = new AbilityData[7];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC LAUNCHER";
        abilities[aCount].abilityDescription = "Three-round burst gun.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-launcher";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:Three-round-burst 7.2 - 24 per round";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:25 to 45 meters";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 burst per 0.58 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:45";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.33 s. recovery for secondary";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Baptiste's crosshair moves up as he fires, then comes back down after firing.";
        abilities[aCount].abilityDetails[++bCount] = "Reloading Biotic Launcher replenishes the ammo for both the primary and alternate fire.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC LAUNCHER";
        abilities[aCount].abilityDescription = "Lob a healing projectile that heals all allies near the impact.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-launcher";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:70 (direct hit) 50(explosion)";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:60 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:3 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:1 shot per 0.9 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:10";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.5 seconds animations";
        abilities[aCount].abilityDetails[++bCount] = "            0.95 seconds while continuously firing";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.14 s. recovery for primary";
        abilities[aCount].abilityDetails[++bCount] = "Cannot heal self.";
        abilities[aCount].abilityDetails[++bCount] = "Goes through full-health allies.";
        abilities[aCount].abilityDetails[++bCount] = "Baptiste can alternate between the two modes of fire.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "REGENERATIVE BURST";
        abilities[aCount].abilityDescription = "Activate to heal yourself and nearby allies over time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RegenerativeBurst";
        abilities[aCount].abilityVideo = hero + "/ability-regenerative-burst";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:15 per second (allies), 75 overall";
        abilities[aCount].abilityDetails[++bCount] = "           30 per second (self), 150 overall";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:10 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.38 seconds (can't be interrupted)";
        abilities[aCount].abilityDetails[++bCount] = "Duration:5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:13 seconds";
        abilities[aCount].abilityDetails[++bCount] = "The heal-over-time effect is applied once upon activation. Allies can get out of range and continue to get healed.";
        abilities[aCount].abilityDetails[++bCount] = "Cannot be interrupted by stuns, hacks or death";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "IMMORTALITY FIELD";
        abilities[aCount].abilityDescription = "Toss a device that prevents allies from dying. The device can be destroyed.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ImmortalityField";
        abilities[aCount].abilityVideo = hero + "/ability-immortality-field";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:150";
        abilities[aCount].abilityDetails[++bCount] = "Healing:Any deficit from 10% HP";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:60 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:6.5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.8 second cast animation";
        abilities[aCount].abilityDetails[++bCount] = "Duration:5 seconds (generator)";
        abilities[aCount].abilityDetails[++bCount] = "          5.5 seconds (field)";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:25 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Prevents the HP of Baptiste and his allies from going below 10%.";
        abilities[aCount].abilityDetails[++bCount] = "Heroes with HP below 10% will instantly be healed to 10% when entering the field.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "AMPLIFICATION MATRIX";
        abilities[aCount].abilityDescription = "Project a matrix that doubles the damage and healing effects of allied projectiles.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AmplificationMatrix";
        abilities[aCount].abilityVideo = hero + "/ability-amplification-matrix";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:+100% damage amplified";
        abilities[aCount].abilityDetails[++bCount] = "Healing:+100% healing amplified";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:35 meters";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:9x5 meter rectangle, with 1 meter beneath the ground";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + recovery 0.24 s. for shoot";
        abilities[aCount].abilityDetails[++bCount] = "Duration:10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:2310 points";
        abilities[aCount].abilityDetails[++bCount] = "Before being deployed, the orientation can be changed by pressing the ultimate key again.";
        abilities[aCount].abilityDetails[++bCount] = "Can be destroyed by EMP.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EXO BOOTS: CHARGE";
        abilities[aCount].abilityDescription = "Hold crouch to charge your Exo Boots.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ExoBoots";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.B;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "Max. range:9.1 meters (full charge)";
        abilities[aCount].abilityDetails[++bCount] = "Takes 1 second for the boots to fully charge.";
        abilities[aCount].abilityDetails[++bCount] = "If crouch is released, the boots will remain charged for 1 second. However, if crouch is pressed again during this time, it will reset.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EXO BOOTS: JUMP";
        abilities[aCount].abilityDescription = "Release the charge in your Exo Boots to increase the height of your jump. If there is no charge you will jump normally.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ExoBoots";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "Max. range:9.1 meters (full charge)";
        abilities[aCount].abilityDetails[++bCount] = "Takes 1 second for the boots to fully charge.";
        abilities[aCount].abilityDetails[++bCount] = "If crouch is released, the boots will remain charged for 1 second. However, if crouch is pressed again during this time, it will reset.";

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