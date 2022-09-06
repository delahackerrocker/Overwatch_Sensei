using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WidowmakerHD : HeroData
{
    public WidowmakerHD() : base()
    {
        this.hero = HERO_ID.Widowmaker;
        this.health = 175;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Widowmaker equips herself with whatever it takes to eliminate her targets, including mines that dispense poisonous gas, a visor that grants her squad infra-sight, and a powerful sniper rifle that can fire in fully-automatic mode.";
        stars = 2;

        abilities = new AbilityData[5];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "WIDOW'S KISS";
        abilities[aCount].abilityDescription = "Should targets close to medium range, the rifle can also be fired in fully-automatic mode.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WidowsKiss";
        abilities[aCount].abilityVideo = hero + "/ability-widows-kiss";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 3.9 - 13";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 20 to 40 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Max: 3.00 degrees";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 10 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 35";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SNIPER MODE";
        abilities[aCount].abilityDescription = "Widowmaker?s versatile sniper rifle is ideal for scope-aimed shots at distant targets.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WidowsKiss";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[14];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 3.6 - 12 (at 0% power)\n        36 - 120(at 100 % power)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Falloff Range:</b> 70 to 100 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -65%";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> Up to 0.9 seconds to charge\n            0.5 second recovery before recharging";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 35";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo Usage:</b> 5 per shot";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.9 seconds charging\n            0.33 seconds scoping in/out";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes (2.5x multiplier)";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the power is below 50%, it makes a softer sound and leaves a smaller trail.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe base damage is 12 and scales linearly to 120. Each percent of power increases the damage by 1.08.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe minimum power required to kill a full health target (without armor) with a single headshot:";
        abilities[aCount].abilityDetails[++bCount] = " - 150 HP: 45%\n- 200 HP: 63%\n - 250 HP: 82% ";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "VENOM MINE";
        abilities[aCount].abilityDescription = "Widowmaker adheres a swiftly-arming venom mine to nearly any surface. When a target wanders within range of the mine?s motion trigger, it explodes, delivering poison gas to any enemies in the vicinity.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/VenomMine";
        abilities[aCount].abilityVideo = hero + "/ability-venom-mine";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 1";
        abilities[aCount].abilityDetails[++bCount] = "<b>Damage:</b> 115 per second\n        75 total";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 20 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 3 meter interact radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.19 s. for throw + 0.78 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 5 seconds after detonation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nEnemies who trigger the mine can be seen by Widowmaker through walls for a short time.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe venom effect is removed immediately upon taking a Health Pack.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the ability is interrupted before cast time ends, the ability's cooldown will not trigger.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GRAPPLING HOOK";
        abilities[aCount].abilityDescription = "Widowmaker launches a grappling hook towards the location she?s aiming at ? when the hook connects with a scalable surface, she?s quickly drawn towards it, allowing her to expand her view of the battlefield and evade or flank targets.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GrapplingHook";
        abilities[aCount].abilityVideo = hero + "/ability-grappling-hook";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[4];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> 20 meters per second (pulling speed)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 20 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nGrappling Hook can be cancelled by pressing the jump key.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "INFRA-SIGHT";
        abilities[aCount].abilityDescription = "Widowmaker?s recon visor allows her to see the heat signatures of her targets through walls and objects for a moderate amount of time. This enhanced vision is shared with her allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/InfraSight";
        abilities[aCount].abilityVideo = hero + "/ability-infra-sight";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Area of Effect:</b> Map-wide";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.69 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 15 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1540 points";
        abilities[aCount].abilityDetails[++bCount] = "\nAllows Widowmaker's entire team to see enemies through walls and their health bars.";
        abilities[aCount].abilityDetails[++bCount] = "\nInfra-Sight ends if Widowmaker dies.";

        strongAgainst = new HERO_ID[8];
        strongAgainst[0] = HERO_ID.Ana;
        strongAgainst[1] = HERO_ID.Ashe;
        strongAgainst[2] = HERO_ID.Baptiste;
        strongAgainst[3] = HERO_ID.Bastion;
        strongAgainst[4] = HERO_ID.Brigitte;
        strongAgainst[5] = HERO_ID.Cassidy;
        strongAgainst[6] = HERO_ID.Reaper;
        strongAgainst[7] = HERO_ID.Symmetra;

        weakAgainst = new HERO_ID[7];
        weakAgainst[0] = HERO_ID.DVa;
        weakAgainst[1] = HERO_ID.Genji;
        weakAgainst[2] = HERO_ID.Orisa;
        weakAgainst[3] = HERO_ID.Reinhardt;
        weakAgainst[4] = HERO_ID.Winston;
        weakAgainst[5] = HERO_ID.WreckingBall;
        weakAgainst[6] = HERO_ID.Sombra;
    }
}