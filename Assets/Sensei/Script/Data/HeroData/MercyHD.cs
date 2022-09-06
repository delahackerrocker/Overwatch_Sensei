using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercyHD : HeroData
{
    public MercyHD() : base()
    {
        this.hero = HERO_ID.Mercy;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;
        int bCount = 0;

        description = "";
        stars = 1;

        abilities = new AbilityData[7];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS STAFF";
        abilities[aCount].abilityDescription = "Hold to heal an ally.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusStaff";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-staff";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Mercy engages one of two beams that connect to an ally. By maintaining the beams, she can either restore that ally?s health or increase the amount of damage they deal.";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> +30% damage amplified";
        abilities[aCount].abilityDetails[++bCount] = "<b>Healing:</b> 55 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 15 meters";
        abilities[aCount].abilityDetails[++bCount] = "\nHeals an ally by 10.56 every 0.192 s.";
        abilities[aCount].abilityDetails[++bCount] = "\nPrimary fire creates a healing beam and secondary fire creates a damage amplifying beam that lock on to a nearby ally. They ignore barriers and will linger for 1.3 seconds if the target breaks line of sight or moves out of range. Mercy does not need to look at her target to maintain connection.";
        abilities[aCount].abilityDetails[++bCount] = "\nIn order to amplify a type's damage, Mercy must be boosting the hero when the projectile was fired. After that, it will be boosted even if Mercy stops boosting when it lands.";
        abilities[aCount].abilityDetails[++bCount] = "\nMercy gains ultimate charge equal to the damage that she amplifies, except from self-damage.";
        abilities[aCount].abilityDetails[++bCount] = "\nMercy's damage boost does not stack with itself.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS BLASTER";
        abilities[aCount].abilityDescription = "Mercy shoots a round from her sidearm. It's best reserved for emergency personal defense.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusBlaster";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-blaster";
        abilities[aCount].controllerButton = ControllerButton.DPadRight;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 20";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 50 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.25 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 5 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 20";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nThe blaster is automatically reloaded if not equipped for 1.4 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nUpon switching weapon, there is 0.51 second recovery period where Mercy cannot use her weapon.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS STAFF";
        abilities[aCount].abilityDescription = "Mercy engages one of two beams that connect to an ally. By maintaining the beams, she can either restore that ally?s health or increase the amount of damage they deal.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusStaff";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-staff";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> +30% damage amplified";
        abilities[aCount].abilityDetails[++bCount] = "<b>Healing:</b> 55 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 15 meters";
        abilities[aCount].abilityDetails[++bCount] = "\nHeals an ally by 10.56 every 0.192 s.";
        abilities[aCount].abilityDetails[++bCount] = "\nPrimary fire creates a healing beam and secondary fire creates a damage amplifying beam that lock on to a nearby ally. They ignore barriers and will linger for 1.3 seconds if the target breaks line of sight or moves out of range. Mercy does not need to look at her target to maintain connection.";
        abilities[aCount].abilityDetails[++bCount] = "\nIn order to amplify a type's damage, Mercy must be boosting the hero when the projectile was fired. After that, it will be boosted even if Mercy stops boosting when it lands.";
        abilities[aCount].abilityDetails[++bCount] = "\nMercy gains ultimate charge equal to the damage that she amplifies, except from self-damage.";
        abilities[aCount].abilityDetails[++bCount] = "\nMercy's damage boost does not stack with itself.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RESURRECT";
        abilities[aCount].abilityDescription = "Revive a dead teammate.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Resurrect";
        abilities[aCount].abilityVideo = hero + "/ability-resurrect";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "Mercy brings a dead ally back into the fight with full health.";
        abilities[aCount].abilityDetails[++bCount] = "<b>Healing:</b> Restores full health to a fallen ally";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -75% penalty";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 5 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1.75 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 30 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ult. Charge Gain:</b> None";
        abilities[aCount].abilityDetails[++bCount] = "\nLine of sight does not need to be maintained.";
        abilities[aCount].abilityDetails[++bCount] = "\nCooldown immediately starts without resurrecting when interrupted or if Mercy is more than 7 meters away from her target while channeling.";
        abilities[aCount].abilityDetails[++bCount] = "\nCooldown does not reset when respawning.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe fallen ally is highlighted on the player's screen.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe resurrected players gain 2.25 seconds of invulnerability. Until the end of invulnerability, the resurrected player cannot use shooting or abilities.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe target can start moving 1.5 seconds after being resurrected.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "VALKYRIE";
        abilities[aCount].abilityDescription = "Gain the ability to fly. Mercy?s abilities are enhanced.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Valkyrie";
        abilities[aCount].abilityVideo = hero + "/ability-valkyrie";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[15];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Chain-damage boost (30% per target)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Healing:</b> 20 HP/s (Mercy)\n        60 HP / s per target(Allies)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> 9 m/s (omni-directional flight)\n          25 m / s(Guardian Angel)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 100 m/s (Blaster)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 10 meters (chain healing)\n          + 100 % range(Guardian Angel, Caduceus Staff)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> ? (Blaster)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.5 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1820 points";
        abilities[aCount].abilityDetails[++bCount] = "\nMercy passively generates 1% Ult Charge every 3.64 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nRegeneration is no longer interrupted by damage.";
        abilities[aCount].abilityDetails[++bCount] = "\nCaduceus Staff's beam branches out from the beam target to nearby allies within line of sight (of the beam target).";
        abilities[aCount].abilityDetails[++bCount] = "\nMercy gains vision of enemy health bars if they have taken damage (even if Mercy did not deal the damage herself).";
        abilities[aCount].abilityDetails[++bCount] = "\nHolding Jump causes Mercy to rise while holding Crouch causes her to descend.";
        abilities[aCount].abilityDetails[++bCount] = "\nVertical and horizontal speed are related. You can't have 9.0 meters per second of horizontal and vertical speed in same time.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "REGENERATION";
        abilities[aCount].abilityDescription = "Mercy automatically heals over time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Regeneration";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> 20 health per second after not taking damage for 1 second";
        abilities[aCount].abilityDetails[++bCount] = "\nDoes not generate ultimate charge.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ANGELIC DESCENT";
        abilities[aCount].abilityDescription = "Propelled by her Valkyrie suit, Mercy slows the speed of her descent from great heights.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AngelicDescent";
        abilities[aCount].abilityVideo = hero + "/ability-angelic-descent";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> Vertical: 2 m/s (down)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Until cancelled";
        abilities[aCount].abilityDetails[++bCount] = "\nBy holding the jump key, Mercy glides through the air.";

        strongAgainst = new HERO_ID[0];

        weakAgainst = new HERO_ID[8];
        weakAgainst[0] = HERO_ID.Ashe;
        weakAgainst[1] = HERO_ID.Reaper;
        weakAgainst[2] = HERO_ID.Tracer;
        weakAgainst[3] = HERO_ID.Sombra;
        weakAgainst[4] = HERO_ID.Roadhog;
        weakAgainst[5] = HERO_ID.Mei;
        weakAgainst[6] = HERO_ID.Widowmaker;
        weakAgainst[7] = HERO_ID.Winston;
    }
}