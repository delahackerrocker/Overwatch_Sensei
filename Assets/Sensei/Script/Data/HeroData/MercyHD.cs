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
        abilities[aCount].abilityDetails[bCount = 0] = "Mercy engages one of two beams that connect to an ally. By maintaining the beams, she can either restore that ally’s health or increase the amount of damage they deal.";
        abilities[aCount].abilityDetails[++bCount] = "Damage:+30% damage amplified";
        abilities[aCount].abilityDetails[++bCount] = "Healing:55 per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:15 meters";
        abilities[aCount].abilityDetails[++bCount] = "Heals an ally by 10.56 every 0.192 s.";
        abilities[aCount].abilityDetails[++bCount] = "Primary fire creates a healing beam and secondary fire creates a damage amplifying beam that lock on to a nearby ally. They ignore barriers and will linger for 1.3 seconds if the target breaks line of sight or moves out of range. Mercy does not need to look at her target to maintain connection.";
        abilities[aCount].abilityDetails[++bCount] = "In order to amplify a type's damage, Mercy must be boosting the hero when the projectile was fired. After that, it will be boosted even if Mercy stops boosting when it lands.";
        abilities[aCount].abilityDetails[++bCount] = "Mercy gains ultimate charge equal to the damage that she amplifies, except from self-damage.";
        abilities[aCount].abilityDetails[++bCount] = "Mercy's damage boost does not stack with itself.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS BLASTER";
        abilities[aCount].abilityDescription = "Mercy shoots a round from her sidearm. It's best reserved for emergency personal defense.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusBlaster";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-blaster";
        abilities[aCount].controllerButton = ControllerButton.DPadRight;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:20";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:50 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:0.25 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:5 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:20";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "The blaster is automatically reloaded if not equipped for 1.4 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "Upon switching weapon, there is 0.51 second recovery period where Mercy cannot use her weapon.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CADUCEUS STAFF";
        abilities[aCount].abilityDescription = "Mercy engages one of two beams that connect to an ally. By maintaining the beams, she can either restore that ally’s health or increase the amount of damage they deal.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CaduceusStaff";
        abilities[aCount].abilityVideo = hero + "/ability-caduceus-staff";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:+30% damage amplified";
        abilities[aCount].abilityDetails[++bCount] = "Healing:55 per second";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:15 meters";
        abilities[aCount].abilityDetails[++bCount] = "Heals an ally by 10.56 every 0.192 s.";
        abilities[aCount].abilityDetails[++bCount] = "Primary fire creates a healing beam and secondary fire creates a damage amplifying beam that lock on to a nearby ally. They ignore barriers and will linger for 1.3 seconds if the target breaks line of sight or moves out of range. Mercy does not need to look at her target to maintain connection.";
        abilities[aCount].abilityDetails[++bCount] = "In order to amplify a type's damage, Mercy must be boosting the hero when the projectile was fired. After that, it will be boosted even if Mercy stops boosting when it lands.";
        abilities[aCount].abilityDetails[++bCount] = "Mercy gains ultimate charge equal to the damage that she amplifies, except from self-damage.";
        abilities[aCount].abilityDetails[++bCount] = "Mercy's damage boost does not stack with itself.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RESURRECT";
        abilities[aCount].abilityDescription = "Revive a dead teammate.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Resurrect";
        abilities[aCount].abilityVideo = hero + "/ability-resurrect";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "Mercy brings a dead ally back into the fight with full health.";
        abilities[aCount].abilityDetails[++bCount] = "Healing:Restores full health to a fallen ally";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:-75% penalty";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:5 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:1.75 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:30 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ult. charge gain:None";
        abilities[aCount].abilityDetails[++bCount] = "Line of sight does not need to be maintained.";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown immediately starts without resurrecting when interrupted or if Mercy is more than 7 meters away from her target while channeling.";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown does not reset when respawning.";
        abilities[aCount].abilityDetails[++bCount] = "The fallen ally is highlighted on the player's screen.";
        abilities[aCount].abilityDetails[++bCount] = "The resurrected players gain 2.25 seconds of invulnerability. Until the end of invulnerability, the resurrected player cannot use shooting or abilities.";
        abilities[aCount].abilityDetails[++bCount] = "The target can start moving 1.5 seconds after being resurrected.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "VALKYRIE";
        abilities[aCount].abilityDescription = "Gain the ability to fly. Mercy’s abilities are enhanced.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Valkyrie";
        abilities[aCount].abilityVideo = hero + "/ability-valkyrie";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[15];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:Chain-damage boost (30% per target)";
        abilities[aCount].abilityDetails[++bCount] = "Healing:20 HP/s (Mercy)\n        60 HP / s per target(Allies)";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:9 m/s (omni-directional flight)\n          25 m / s(Guardian Angel)";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:100 m/s (Blaster)";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:10 meters (chain healing)\n          + 100 % range(Guardian Angel, Caduceus Staff)";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:? (Blaster)";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.5 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1820 points";
        abilities[aCount].abilityDetails[++bCount] = "Mercy passively generates 1% Ult Charge every 3.64 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "Regeneration is no longer interrupted by damage.";
        abilities[aCount].abilityDetails[++bCount] = "Caduceus Staff's beam branches out from the beam target to nearby allies within line of sight (of the beam target).";
        abilities[aCount].abilityDetails[++bCount] = "Mercy gains vision of enemy health bars if they have taken damage (even if Mercy did not deal the damage herself).";
        abilities[aCount].abilityDetails[++bCount] = "Holding Jump causes Mercy to rise while holding Crouch causes her to descend.";
        abilities[aCount].abilityDetails[++bCount] = "Vertical and horizontal speed are related. You can't have 9.0 meters per second of horizontal and vertical speed in same time.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "REGENERATION";
        abilities[aCount].abilityDescription = "Mercy automatically heals over time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Regeneration";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:20 health per second after not taking damage for 1 second";
        abilities[aCount].abilityDetails[++bCount] = "Does not generate ultimate charge.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ANGELIC DESCENT";
        abilities[aCount].abilityDescription = "Propelled by her Valkyrie suit, Mercy slows the speed of her descent from great heights.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AngelicDescent";
        abilities[aCount].abilityVideo = hero + "/ability-angelic-descent";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:Vertical: 2 m/s (down)";
        abilities[aCount].abilityDetails[++bCount] = "Duration:Until cancelled";
        abilities[aCount].abilityDetails[++bCount] = "By holding the jump key, Mercy glides through the air.";

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