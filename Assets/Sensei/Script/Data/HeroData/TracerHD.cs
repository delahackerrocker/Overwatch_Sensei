using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerHD : HeroData
{
    public TracerHD() : base()
    {
        this.hero = HERO_ID.Tracer;
        this.health = 150;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Toting twin pulse pistols, energy-based time bombs, and rapid-fire banter, Tracer is able to 'blink' through space and rewind her personal timeline as she battles to right wrongs the world over.";
        stars = 2;

        abilities = new AbilityData[4];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PULSE PISTOLS";
        abilities[aCount].abilityDescription = "Tracer rapid-fires both of her pistols.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PulsePistols";
        abilities[aCount].abilityVideo = hero + "/ability-pulse-pistols";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 1.8 - 6 per bullet\n        3.6 - 12 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 12 to 20 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Max: 3.6 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> 2 bullets per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 20 shots per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 40";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 2 rounds per 0.048 seconds\n            0.944 seconds for 40 rounds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BLINK";
        abilities[aCount].abilityDescription = "Tracer zips horizontally through space in the direction she?s moving, and reappears several yards away. She stores up to three charges of the blink ability and generates more every few seconds.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Blink";
        abilities[aCount].abilityVideo = hero + "/ability-blink";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Max Range:</b> 7.5 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 3 charges";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.096 s. recovery for reuse";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 3 seconds per charge\n          9 seconds for all three charges";
        abilities[aCount].abilityDetails[++bCount] = "\nTracer will be caught by Junkrat's Steel Trap if she attempts to Blink over it, and cannot Blink out of one that she has already triggered.";
        abilities[aCount].abilityDetails[++bCount] = "\nTracer will activate Widow's Venom Mine if she Blinks past it.";
        abilities[aCount].abilityDetails[++bCount] = "\nBlink will not remove debuffs.";
        abilities[aCount].abilityDetails[++bCount] = "\nCan also be used with Secondary Fire.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "RECALL";
        abilities[aCount].abilityDescription = "Tracer bounds backward in time, returning her health, ammo and position on the map to precisely where they were a few seconds before.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Recall";
        abilities[aCount].abilityVideo = hero + "/ability-recall";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Health returned to the highest value in the past 3 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 0.91 seconds rewinding\n          Rewinds 3 seconds back";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nDespite its description, Recall does not return Tracer's ammo to what it was a few seconds earlier, but instead fully reloads her weapons.";
        abilities[aCount].abilityDetails[++bCount] = "\nRecall does not restore temporary armor or temporary personal shields.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Recalling to a position on a platform (or the payload) that has moved during the last few seconds, Tracer will not be Recalled to a position in the air, but instead she will be returned to the platform, wherever the platform is now.";
        abilities[aCount].abilityDetails[++bCount] = "\nRecall also records where Tracer was looking three seconds prior.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PULSE BOMB";
        abilities[aCount].abilityDescription = "Tracer lobs a large bomb that adheres to any surface or unfortunate opponent it lands on. After a brief delay, the bomb explodes, dealing high damage to all enemies within its blast radius.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PulseBomb";
        abilities[aCount].abilityVideo = hero + "/ability-pulse-bomb";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Stick: 5\n        Explosion: 70 - 350\n        Self: 70 - 350";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 15 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 5 meter explosion radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.144 seconds for throw + 0.192 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 1 second after stick";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1260 points";
        abilities[aCount].abilityDetails[++bCount] = "\nTracer's Pulse Bomb does damage when stuck to someone and when it explodes.";

        strongAgainst = new HERO_ID[6];
        strongAgainst[0] = HERO_ID.Ana;
        strongAgainst[1] = HERO_ID.Hanzo;
        strongAgainst[2] = HERO_ID.Mercy;
        strongAgainst[3] = HERO_ID.Bastion;
        strongAgainst[4] = HERO_ID.Orisa;
        strongAgainst[5] = HERO_ID.Zenyatta;

        weakAgainst = new HERO_ID[6];
        weakAgainst[0] = HERO_ID.Brigitte;
        weakAgainst[1] = HERO_ID.Junkrat;
        weakAgainst[2] = HERO_ID.Sombra;
        weakAgainst[3] = HERO_ID.Torbjorn;
        weakAgainst[4] = HERO_ID.Symmetra;
        weakAgainst[5] = HERO_ID.Winston;
    }
}