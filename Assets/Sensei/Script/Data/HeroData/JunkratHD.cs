using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkratHD : HeroData
{
    public JunkratHD() : base()
    {
        this.hero = HERO_ID.Junkrat;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Junkrat’s area-denying armaments include a Frag Launcher that lobs bouncing grenades, Concussion Mines that send enemies flying, and Steel Traps that stop foes dead in their tracks.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "FRAG LAUNCHER";
        abilities[aCount].abilityDescription = "Junkrat's Frag Launcher lobs grenades a significant distance. They bounce to reach their destination, and blow up when they strike an enemy.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FragLauncher";
        abilities[aCount].abilityVideo = hero + "/ability-frag-launcher";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Direct hit: 120\n               Splash: 10 - 80";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.2 meters (projectile size)\n                      2 meters(splash radius)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 shot per 0.64 seconds\n                    extra delay while using meleee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 5";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nThe grenades explode after two bounces or when they hit an enemy unit.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CONCUSSION MINE";
        abilities[aCount].abilityDescription = "After placing one of his homemade Concussion Mines, Junkrat can trigger it to damage enemies and send them flying... or propel himself through the air.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ConcussionMine";
        abilities[aCount].abilityVideo = hero + "/ability-concussion-mine";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[13];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 25";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 30-120";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 3 meters radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 2 charges";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.128 second for throw + 0.112 s. recovery for detonation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Until detonated";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds per charge";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Junkrat throws another mine while one is already deployed the first mine will instantly and silently disappear.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe mine does not deal self-damage, but still applies the knockback, making it usable as a mobility tool.";
        abilities[aCount].abilityDetails[++bCount] = "\nJunkrat and enemies caught in the blast are knocked up 45° vertically, regardless of their position relative to the mine.";
        abilities[aCount].abilityDetails[++bCount] = "\nHorizontal knockback is away from the center of the mine.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STEEL TRAP";
        abilities[aCount].abilityDescription = "Junkrat tosses out a giant, metal-toothed trap. Should an enemy wander too close to the trap, it clamps on, injuring and immobilizing them.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SteelTrap";
        abilities[aCount].abilityVideo = hero + "/ability-steel-trap";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 100";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 80";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 10 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 1 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.33 s recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 3 seconds root";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nSimilarly to his Concussion Mine, deploying a second Steel Trap will remove the first.";
        abilities[aCount].abilityDetails[++bCount] = "\nJunkrat can see the trap's location through walls.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe player receives an audio cue when an enemy triggers the trap.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RIP-TIRE";
        abilities[aCount].abilityDescription = "Junkrat revs up a motorized tire bomb and sends it rolling across the battlefield, climbing over walls and obstacles. He can remotely detonate the RIP-Tire to deal serious damage to enemies caught in the blast, or just wait for it to explode on its own.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RipTire";
        abilities[aCount].abilityVideo = hero + "/ability-rip-tire";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 100";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 50 - 600";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> Junkrat: Immobilized\n           Tire: 12 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 10 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 1.536 seconds + recovery 0.08 s.";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> Up to 10 seconds + recovery 0.9 s.";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1925 points";
        abilities[aCount].abilityDetails[++bCount] = "\nAfter the initial cast and gaining control of RIP-Tire, the ability will continue regardless of any crowd control or if Junkrat dies.";
        abilities[aCount].abilityDetails[++bCount] = "\nInstantly restores Frag Launcher ammo";
        abilities[aCount].abilityDetails[++bCount] = "\nIt takes 0.9 seconds to regain control of Junkrat.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TOTAL MAYHEM";
        abilities[aCount].abilityDescription = "Junkrat's deranged sense of humor persists past his death. If killed, he drops several live grenades.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TotalMayhem";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[5];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 50 per grenade";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> 6 grenades";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.7 seconds (detonation)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nAlso causes Junkrat to not take damage from his own explosions.";

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