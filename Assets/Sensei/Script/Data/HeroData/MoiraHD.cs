using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoiraHD : HeroData
{
    public MoiraHD() : base()
    {
        this.hero = HERO_ID.Moira;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;
        int bCount = 0;

        description = "Moira’s biotic abilities enable her to contribute healing or damage in any crisis. While Biotic Grasp gives Moira short-range options, her Biotic Orbs contribute longer-range, hands-off damage and healing; she can also Fade to escape groups or remain close to allies in need of support. Once she’s charged Coalescence, Moira can save multiple allies from elimination at once or finish off weakened enemies.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC GRASP";
        abilities[aCount].abilityDescription = "Hold to heal all allies in front of you. Consumes biotic energy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticGrasp";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-grasp";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Healing:70 per second, then lingers to heal 35 over 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:15 meters";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:160 biotic energy";
        abilities[aCount].abilityDetails[++bCount] = "Ammo usage:12.5 energy per second";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.08 seconds for heal";
        abilities[aCount].abilityDetails[++bCount] = "Duration:2 seconds (remainder)";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Passes through allies and enemies, but not enemy barriers.";
        abilities[aCount].abilityDetails[++bCount] = "Regenerates 3.84 biotic energy per second while inactive.";
        abilities[aCount].abilityDetails[++bCount] = "Needs at least 8 biotic energy to activate.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC GRASP - ALT FIRE";
        abilities[aCount].abilityDescription = "Long range beam weapon. Damage dealt heals you and replenishes your biotic energy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticGrasp";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-grasp";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:50 per second";
        abilities[aCount].abilityDetails[++bCount] = "Healing:24 per second (self)";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:20 meters";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:?";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Like Targeted abilities, line of sight to an enemies center of mass is required to initiate and maintain the attack.";
        abilities[aCount].abilityDetails[++bCount] = "Like Beam abilities, Biotic Grasp is unaffected by Deflect, Defense Matrix, and Kinetic Grasp.";
        abilities[aCount].abilityDetails[++bCount] = "Self-healing and damage are completely separate. Altering the damage does not affect the self heal.";
        abilities[aCount].abilityDetails[++bCount] = "Generates 21.875 biotic energy per second. When combined with the passive regeneration, this becomes 25.715 biotic energy per second (or 16% per second).";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FADE";
        abilities[aCount].abilityDescription = "Moira's movement speed increases while making her invulnerable to damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Fade";
        abilities[aCount].abilityVideo = hero + "/ability-fade";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:+250% buff";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:15 meters (max)";
        abilities[aCount].abilityDetails[++bCount] = "Duration:0.75 seconds + 0.05 s recovery";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Makes Moira invulnerable and invisible. She can still pick up Health Packs.";
        abilities[aCount].abilityDetails[++bCount] = "Cleanses Moira of status and damage over time effects.";
        abilities[aCount].abilityDetails[++bCount] = "Can be used to escape abilities such as Graviton Surge or Gravitic Flux.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BIOTIC ORB";
        abilities[aCount].abilityDescription = "Moira launches a rebounding biotic sphere; she can choose between a regeneration effect that heals the allies it passes through, or a decay effect that deals damage to enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BioticOrb";
        abilities[aCount].abilityVideo = hero + "/ability-biotic-orb";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[12];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:50 per second, up to 200";
        abilities[aCount].abilityDetails[++bCount] = "Healing:65 per second, up to 300";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:20 meters per second\n              5.5 meters per second while tethered";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:4 meters (damage orb)\n           5 meters(healing orb)";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly + 0.4 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:7 seconds, or until depleted";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Bounces off walls.";
        abilities[aCount].abilityDetails[++bCount] = "Pierces barriers, but does not target enemies through them.";
        abilities[aCount].abilityDetails[++bCount] = "Damage Orb does not affect enemy objects.";
        abilities[aCount].abilityDetails[++bCount] = "If amplified, only the rate of damage/healing per second is increased, not the total amount.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "COALESCENCE";
        abilities[aCount].abilityDescription = "Moira channels a long-range beam that heals allies, damages enemies, and bypasses barriers.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Coalescence";
        abilities[aCount].abilityVideo = hero + "/ability-coalescence";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:70 per second";
        abilities[aCount].abilityDetails[++bCount] = "Healing:140 per second\n       50 per second(self)";
        abilities[aCount].abilityDetails[++bCount] = "Move. speed:+50% buff";
        abilities[aCount].abilityDetails[++bCount] = "Max. range:30 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Duration:8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:2800 points";
        abilities[aCount].abilityDetails[++bCount] = "Moira passively recharges her biotic energy three times faster while using Coalescence.";
        abilities[aCount].abilityDetails[++bCount] = "Passes through enemy barriers.";

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