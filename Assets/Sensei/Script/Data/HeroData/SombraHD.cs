using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SombraHD : HeroData
{
    public SombraHD() : base()
    {
        this.hero = HERO_ID.Sombra;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Damage;

        int aCount = 0;
        int bCount = 0;

        description = "Stealth and debilitating attacks make Sombra a powerful infiltrator. Her hacking can disrupt her enemies, ensuring they're easier to take out, while her EMP provides the upper hand against multiple foes at once. Sombra’s ability to Translocate and camouflage herself makes her a hard target to pin down.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "MACHINE PISTOL";
        abilities[aCount].abilityDescription = "Sombra’s fully-automatic machine pistol fires in a short-range spread.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MachinePistol";
        abilities[aCount].abilityVideo = hero + "/ability-machine-pistol";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:2.4–8";
        abilities[aCount].abilityDetails[++bCount] = "Falloff range:15 to 35 meters";
        abilities[aCount].abilityDetails[++bCount] = "Spread angle:Max: 2.4 degrees";
        abilities[aCount].abilityDetails[++bCount] = "Rate of fire:20 rounds per second";
        abilities[aCount].abilityDetails[++bCount] = "Ammo:60";
        abilities[aCount].abilityDetails[++bCount] = "Reload time:1.4 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "Headshot:?";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STEALTH";
        abilities[aCount].abilityDescription = "Sombra becomes invisible for a short period of time, during which her speed is boosted considerably. Attacking, using offensive abilities, or taking damage disables her camouflage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Stealth";
        abilities[aCount].abilityVideo = hero + "/ability-stealth";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Move. speed:+65% buff";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:2 meter radius (detection)";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.75 seconds for activate\n            instantly for disable + 0.75 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:?";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "While stealthed, Sombra cannot be targeted by auto-targeting attacks (e.g. turrets, Biotic Orb, Deadeye, etc.), unless Sombra is detected.";
        abilities[aCount].abilityDetails[++bCount] = "Sombra becomes detected if there is an enemy within 2 meters of her, or through abilities such as Sonic Arrow and Infra-Sight. In case of the former, only the nearby enemy detects Sombra, but in the case of the latter two, the entire enemy team detects Sombra. A 'DETECTED!' message will appear at the top of Sombra's screen.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TRANSLOCATOR";
        abilities[aCount].abilityDescription = "Sombra tosses out a translocator beacon. She can instantly return to the beacon’s location while it is active (including when it’s in mid-flight).";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Translocator";
        abilities[aCount].abilityVideo = hero + "/ability-translocator";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Health:5";
        abilities[aCount].abilityDetails[++bCount] = "Projectile speed:25 meters per second";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:instantly for throw + 0.5 s. recovery\n               instantly for teleport + 0.4 s.recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:?";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:6 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown for Translocator begins immediately upon throwing it, or when it is destroyed.";
        abilities[aCount].abilityDetails[++bCount] = "Can be manually destroyed using the Interact key. Destroying it this way does not reset the cooldown.";
        abilities[aCount].abilityDetails[++bCount] = "The Translocator bounces off walls but not slopes.";
        abilities[aCount].abilityDetails[++bCount] = "Sombra has a very brief moment of invincibility upon translocating.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "HACK";
        abilities[aCount].abilityDescription = "Hold to hack. Hacked enemies cannot use abilities. Hacked health packs spawn faster but can't be used by enemies. Taking damage interrupts the hack attempt.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Hack";
        abilities[aCount].abilityVideo = hero + "/ability-hack";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "Max. range:15 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.65 seconds + 0.3 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:Enemies & B.O.B.: 5 seconds\n           Health Packs: 60 seconds\n           Other: 10 seconds";
        abilities[aCount].abilityDetails[++bCount] = "Cooldown:8 seconds\n           4 seconds(Health Pack)\n           2 seconds(broken)";
        abilities[aCount].abilityDetails[++bCount] = "Taking damage interrupts Hack and it will go on a 2 second cooldown. If Hack is interrupted without taking any damage, it does not go on cooldown.";
        abilities[aCount].abilityDetails[++bCount] = "Hacked enemies cannot activate their abilities. For passive abilities, Hack only disables the ones that require a button to press. For transformations, Hack cancels transformations from normal abilities, but not from ultimate abilities. Hack also turns off Lúcio's song and disables Sigma's barrier. Hack does not affect weapons.";
        abilities[aCount].abilityDetails[++bCount] = "Hacked enemies have their health bar revealed to Sombra's team for 20 seconds. If their ultimate ability is ready, an icon appears on top to show this.";
        abilities[aCount].abilityDetails[++bCount] = "Hacked Health Packs respawn four times faster—2.5 seconds for small Health Packs, 3.75 seconds for mega Health Packs—and can be seen through walls to all allies within 30 meters. Hacked Health Packs cannot be used by the enemy team.";
        abilities[aCount].abilityDetails[++bCount] = "Hack can also target the following: Ashe's B.O.B., Baptiste's Immortality Field, Orisa's Supercharger, and Torbjörn's turret. With the exception of B.O.B., they are disabled for 10 seconds. Sombra cannot hack Symmetra's Sentry Turrets or teleporter normally, only with the use of EMP";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EMP";
        abilities[aCount].abilityDescription = "Sombra discharges electromagnetic energy in a wide radius, destroying enemy barriers and shields and hacking all opponents caught in the blast.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/EMP";
        abilities[aCount].abilityVideo = hero + "/ability-emp";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[11];
        abilities[aCount].abilityDetails[bCount = 0] = "Damage:10,000 against barriers and shields";
        abilities[aCount].abilityDetails[++bCount] = "Area of effect:15 meters";
        abilities[aCount].abilityDetails[++bCount] = "Casting time:0.35 second activation + 0.25 second recovery";
        abilities[aCount].abilityDetails[++bCount] = "Duration:Same as Hack.";
        abilities[aCount].abilityDetails[++bCount] = "Ultimate cost:1400 points";
        abilities[aCount].abilityDetails[++bCount] = "In addition to everything Hack can hack, EMP also hacks Symmetra's Sentry Turrets, Symmetra's Teleporter, and Wrecking Ball's Proximity Mines for 10 seconds. They must be within Sombra's line of sight, ignoring barriers.";
        abilities[aCount].abilityDetails[++bCount] = "EMP inflicts 10,000 damage to all barriers and shields in the area. EMP also destroys Baptiste's Amplification Matrix.";
        abilities[aCount].abilityDetails[++bCount] = "If Zarya projects a barrier on a target with shields (e.g. herself), the barrier protects the shields, but the target will still be hacked.";
        abilities[aCount].abilityDetails[++bCount] = "Unlike other ultimate abilities Sombra alerts her entire team regardless of distance from her that she had used her EMP. This is done by Sombra's image appearing in the bottom right hand corner of the screen to all allies accompanied by a radio transmission sounding 'EMP activated.'";
        abilities[aCount].abilityDetails[++bCount] = "Sombra cannot gain ultimate charge until after EMP wears off for enemy heroes.";
        abilities[aCount].abilityDetails[++bCount] = "Sombra receives a small vertical boost from activating EMP.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "OPPORTUNIST";
        abilities[aCount].abilityDescription = "Sombra detects critically injured enemies through walls.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Opportunist";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "Opportunist detects enemies below 50% health.";
        abilities[aCount].abilityDetails[++bCount] = "The silhouette has a glowing effect to it, different from other wall vision effects.";
        abilities[aCount].abilityDetails[++bCount] = "Reveals enemy health bars that are below 100% to Sombra only, without requiring Sombra to have dealt any damage to them.";

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