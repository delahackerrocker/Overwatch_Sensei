using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadhogHD : HeroData
{
    public RoadhogHD() : base()
    {
        this.hero = HERO_ID.Roadhog;
        this.health = 600;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Roadhog uses his signature Chain Hook to pull his enemies close before shredding them with blasts from his Scrap Gun. He’s hardy enough to withstand tremendous damage, and can recover his health with a short breather.";
        stars = 1;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "SCRAP GUN";
        abilities[aCount].abilityDescription = "Roadhog's Scrap Gun fires short-range blasts of shrapnel with a wide spread.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ScrapGun";
        abilities[aCount].abilityVideo = hero + "/ability-scrap-gun";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 1.98 - 6.6 per pellet\n        49.5 - 165 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 15 to 30 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Constant: 20.1 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 80 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> 25 pellets per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 0.85 second recovery\n          ~1.18 shots per second\n          extra 0.5 if used melee";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 5";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 2 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SCRAP GUN ALT FIRE";
        abilities[aCount].abilityDescription = "Alternatively, it can launch a shrapnel ball that detonates farther away, scattering metal fragments from the point of impact.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ScrapGun";
        abilities[aCount].abilityVideo = hero + "/ability-scrap-gun";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Pre-detonation: 50\n        Post - detonation: 1.98 - 6.6 per pellet\n                49.5 - 165 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 23 to 38 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 80 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 8 meters (pre-detonation)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Pellets:</b> Post-detonation: 25 pellets";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> ~1.18 shots per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 5";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 2 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nRoadhog initially fires a single projectile which then explodes into 25 pellets after travelling 8 m.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CHAIN HOOK";
        abilities[aCount].abilityDescription = "Roadhog hurls his chain at a target; if it catches, he yanks them into close range.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ChainHook";
        abilities[aCount].abilityVideo = hero + "/ability-chain-hook";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[14];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 30";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 40 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 20 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 0.5 meter radius (vs enemy)\n          as hitscan shoot(vs wall or shield)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.16 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nHooked targets are released if they leave Roadhog’s line of sight before being pulled.";
        abilities[aCount].abilityDetails[++bCount] = "\nApplies a short stun, which can interrupt the target's abilities.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe maximum hook flight time to target is ~0.32 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nPulls the target after hit the Hook starts after ~0.3 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nPulls the target to 3 meters away from Roadhog.";
        abilities[aCount].abilityDetails[++bCount] = "\nRoadhog can start shooting as soon as his chain is gone.";
        abilities[aCount].abilityDetails[++bCount] = "\nDamage is inflicted the instant the hook lands. If this damage is enough to kill the target, the hook will return instantly to Roadhog without holding him in place as it usually does on a hit.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TAKE A BREATHER";
        abilities[aCount].abilityDescription = "Heal yourself and reduce damage taken over a short time.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TakeBreather";
        abilities[aCount].abilityVideo = hero + "/ability-take-a-breather";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> 300 health";
        abilities[aCount].abilityDetails[++bCount] = "<b>Dmg. Reduction:</b> 50%";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly for damage reduction\n         0.5 seconds for heal starts\n         2 seconds total animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 1 second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 8 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nThis is a channeled ability; Roadhog can only move while it's being used, and stuns can interrupt the healing effect.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe entire animation of Take A Breather lasts 2 seconds, the part where healing takes place only lasts 1 second.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WHOLE HOG";
        abilities[aCount].abilityDescription = "After cramming a top-loader onto his Scrap Gun, Roadhog pours in ammo. For a short time, he can crank out a stream of shrapnel that knocks back enemies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WholeHog";
        abilities[aCount].abilityVideo = hero + "/ability-whole-hog";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[112];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 7 per pellet, 4928 overall";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -25% penalty";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 128 pellets per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.5 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 5.5 seconds + 1 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2240 points";
        abilities[aCount].abilityDetails[++bCount] = "\nRoadhog cannot control his firerate or use any other abilities during the ultimate; the Scrap Gun simply fires even without a button being pressed.";
        abilities[aCount].abilityDetails[++bCount] = "\nRestores Scrap Gun ammo after the ability ends, provided the ability wasn't canceled prematurely.";
        abilities[aCount].abilityDetails[++bCount] = "\nWhile the ultimate is in use, Roadhog's bullets will have red tracer lines on enemy vision.";
        abilities[aCount].abilityDetails[++bCount] = "\nWhole Hog knocks back enemies at a rate of up to 14 meters per second.";

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