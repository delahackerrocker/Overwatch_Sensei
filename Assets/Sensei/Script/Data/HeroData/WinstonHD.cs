using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinstonHD : HeroData
{
    public WinstonHD() : base()
    {
        this.hero = HERO_ID.Winston;
        this.health = 400;
        this.shields = 0;
        this.armor = 150;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Winston wields impressive inventions?a jump pack, electricity-blasting Tesla Cannon, portable shield projector and more?with literal gorilla strength.";
        stars = 2;

        abilities = new AbilityData[4];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "TESLA CANNON";
        abilities[aCount].abilityDescription = "Winston?s weapon fires a short-range electric barrage for as long as he holds down the trigger.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/TeslaCannon";
        abilities[aCount].abilityVideo = hero + "/ability-tesla-cannon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 60 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 8 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 6 meter width";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 100";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 20 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.7 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BARRIER PROJECTOR";
        abilities[aCount].abilityDescription = "Winston?s barrier projector extends a bubble-shaped field that absorbs damage until it's destroyed. Allies protected by the barrier can return fire from within it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BarrierProjector";
        abilities[aCount].abilityVideo = hero + "/ability-barrier-projector";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 700";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 5 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.08 seconds (can't be interrupted)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 9 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 13 seconds";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "JUMP PACK";
        abilities[aCount].abilityDescription = "Assisted by his energy pack, Winston lunges through the air, dealing significant damage and staggering nearby enemies when he lands.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/JumpPack";
        abilities[aCount].abilityVideo = hero + "/ability-jump-pack";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Jumping: 1\n        Landing: 1 - 50";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> 30 mps (initial)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 18 - 22 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 5 meter radius (landing damage)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 6 seconds\n         2 seconds during Primal Rage";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PRIMAL RAGE";
        abilities[aCount].abilityDescription = "Winston embraces his animal nature, significantly boosting his health and making him very difficult to kill, strengthening his melee attack, and allowing him to use his Jump Pack ability more frequently. While raging, Winston can only make melee and Jump Pack attacks.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/PrimalRage";
        abilities[aCount].abilityVideo = hero + "/ability-primal-rage";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[15];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 850 health, 150 armor";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 40 per swing";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +30% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 4 meter swings";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 0.66 second recovery\n            ~1.5 swings per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.5 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1540 points";
        abilities[aCount].abilityDetails[++bCount] = "\nWinston passively generates 1% Ult Charge every 3.08 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nWinston's HP instantly becomes 1000 upon activation: 850 health and 150 armor.";
        abilities[aCount].abilityDetails[++bCount] = "\nJump Pack's cooldown is reset and lowered to 2 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nBarrier Projector cannot be used.";
        abilities[aCount].abilityDetails[++bCount] = "\nAmmunition is restored after completion.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Winston has more than 350 health at the end of the duration, it becomes 350.";

        strongAgainst = new HERO_ID[8];
        strongAgainst[0] = HERO_ID.Ana;
        strongAgainst[1] = HERO_ID.Genji;
        strongAgainst[2] = HERO_ID.Baptiste;
        strongAgainst[3] = HERO_ID.Hanzo;
        strongAgainst[4] = HERO_ID.Sigma;
        strongAgainst[5] = HERO_ID.Symmetra;
        strongAgainst[6] = HERO_ID.Tracer;
        strongAgainst[7] = HERO_ID.Widowmaker;

        weakAgainst = new HERO_ID[5];
        weakAgainst[0] = HERO_ID.Bastion;
        weakAgainst[1] = HERO_ID.DVa;
        weakAgainst[2] = HERO_ID.Reaper;
        weakAgainst[3] = HERO_ID.Roadhog;
        weakAgainst[4] = HERO_ID.Torbjorn;
    }
}