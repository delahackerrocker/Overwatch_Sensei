using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinhardtHD : HeroData
{
    public ReinhardtHD() : base()
    {
        this.hero = HERO_ID.Reinhardt;
        this.health = 300;
        this.shields = 0;
        this.armor = 200;
        this.role = Role.Tank;

        int aCount = 0;
        int bCount = 0;

        description = "Clad in powered armor and swinging his hammer, Reinhardt leads a rocket-propelled charge across the battleground and defends his squadmates with a massive energy barrier.";
        stars = 1;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "ROCKET HAMMER";
        abilities[aCount].abilityDescription = "Reinhardt?s Rocket Hammer is an exemplary melee weapon, able to deal punishing damage in a wide arc with every swing.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/RocketHammer";
        abilities[aCount].abilityVideo = hero + "/ability-rocket-hammer";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[5];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 85";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 5 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 swing per 0.94 second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.416 second (initial swing)\n          0.208 second(dealing damage)\n          0.320 second(recovery after dealing damage ends)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "BARRIER FIELD";
        abilities[aCount].abilityDescription = "Reinhardt projects a broad, forward-facing energy shield, which can absorb substantial damage before it is destroyed. Though Reinhardt can protect himself and his companions behind the shield, he cannot attack while sustaining it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/BarrierField";
        abilities[aCount].abilityVideo = hero + "/ability-barrier-field";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 1600";
        abilities[aCount].abilityDetails[++bCount] = "<b>Healing:</b> Regenerates 200 barrier health per second, after being down for 2 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> -30% penalty";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> Height 4.250 meters. Width 6.800 meters.";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.08 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 5 seconds if destroyed";
        abilities[aCount].abilityDetails[++bCount] = "\nBy holding the primary fire key, Reinhardt can look around at his surroundings without turning.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe barrier cracks once at 50% and once at 25%. At 20%, Reinhardt will say his barrier is failing.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CHARGE";
        abilities[aCount].abilityDescription = "Reinhardt charges forth in a straight line, grabbing hold of enemies in his path. If he collides with a wall, foes he?s carrying suffer extreme damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Charge";
        abilities[aCount].abilityVideo = hero + "/ability-charge";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> Pinned to a wall: 300\n        Bump with no pin: 50";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +200% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 49.5 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.6 seconds + 0.5 s. recovery if pin the wall";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 3 seconds\n          0.65 second stun at the end of a pin";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nReinhardt can turn while charging but his control is reduced.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Charge directly collides with an enemy, that enemy is 'pinned' (stunned), and if they hit a wall, the pinned target takes 300 damage. If Charge ends before hitting a wall, no damage is inflicted, but the target will remain stunned for an additional 0.65 seconds. Only 1 enemy can be pinned at a time.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Charge indirectly collides with an enemy, or if there is already a target pinned, the enemy is knocked away and takes 50 damage.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Charge collides with Rocket Punch, Shield Bash, a charging B.O.B., or another Charge, both participants get knocked down for 2 seconds. Any pinned targets will be damaged as if they hit a wall.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "FIRE STRIKE";
        abilities[aCount].abilityDescription = "By whipping his Rocket Hammer forward, Reinhardt slings a flaming projectile which pierces and damages any enemies it touches.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/FireStrike";
        abilities[aCount].abilityVideo = hero + "/ability-fire-strike";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 100";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.496 seconds for throw + 0.620 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nPierces barriers, enemies, and other damageable entities.";
        abilities[aCount].abilityDetails[++bCount] = "\nThis ability can animation cancel Ability-reinhardt1.png Rocket Hammer, allowing for faster attacks.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the center of the projectile does not touch the wall, then the projectile will not explode against the wall.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EARTHSHATTER";
        abilities[aCount].abilityDescription = "Reinhardt forcefully slams his rocket hammer into the ground, knocking down and damaging all enemies in front of him.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/EarthShatter";
        abilities[aCount].abilityVideo = hero + "/ability-earthshatter";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 50";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 20 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> height 1.770 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.45 seconds + 0.5 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 2.5 second knock down";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 1540 points";
        abilities[aCount].abilityDetails[++bCount] = "\nReinhardt passively generates 1% Ult Charge every 3.08 seconds.";
        abilities[aCount].abilityDetails[++bCount] = "\nRequires line of sight.";
        abilities[aCount].abilityDetails[++bCount] = "\nEarthshatter has a small amount of vertical height (1.770 meters), allowing it to affect enemies in the air.";
        abilities[aCount].abilityDetails[++bCount] = "\nEarthshatter Will be stopped by barriers, even if the damage from Earthshatter breaks the barrier.";
        abilities[aCount].abilityDetails[++bCount] = "\nEarthshatter deals an additional 200 damage within 1.75m of the impact area.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STEADFAST";
        abilities[aCount].abilityDescription = "Resistant to knock back effects.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Steadfast";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[3];
        abilities[aCount].abilityDetails[bCount = 0] = "Reduces the initial velocity from knock back effects by 30%. For example, Soundwave sends its victims back 17 m/s, but for Reinhardt, it is 11.9 m/s.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe distance in which Reinhardt is knocked back is NOT reduced by 30%; it is reduced by more. This is because the velocity has to accelerate back to normal; a higher initial velocity means more time at higher velocities and more time with a velocity in general.";
        abilities[aCount].abilityDetails[++bCount] = "\nDoes not affect Halt!, Chain Hook, Graviton Surge, or Gravitic Flux because they are not knock back effects.";

        strongAgainst = new HERO_ID[5];
        strongAgainst[0] = HERO_ID.Hanzo;
        strongAgainst[1] = HERO_ID.Ashe;
        strongAgainst[2] = HERO_ID.Baptiste;
        strongAgainst[3] = HERO_ID.Soldier76;
        strongAgainst[4] = HERO_ID.Widowmaker;

        weakAgainst = new HERO_ID[8];
        weakAgainst[0] = HERO_ID.Bastion;
        weakAgainst[1] = HERO_ID.Doomfist;
        weakAgainst[2] = HERO_ID.Moira;
        weakAgainst[3] = HERO_ID.Junkrat;
        weakAgainst[4] = HERO_ID.Reaper;
        weakAgainst[5] = HERO_ID.Mei;
        weakAgainst[6] = HERO_ID.Pharah;
        weakAgainst[7] = HERO_ID.Symmetra;
    }
}