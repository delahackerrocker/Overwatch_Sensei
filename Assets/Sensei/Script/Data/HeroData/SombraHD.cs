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
        abilities[aCount].abilityDescription = "Short-range automatic weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/MachinePistol";
        abilities[aCount].abilityVideo = hero + "/ability-machine-pistol";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "STEALTH";
        abilities[aCount].abilityDescription = "Become invisible and move quickly.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Stealth";
        abilities[aCount].abilityVideo = hero + "/ability-stealth";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "TRANSLOCATOR";
        abilities[aCount].abilityDescription = "Throw a beacon, then press E again to teleport to it. Press ABILITY 2 to remove it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Translocator";
        abilities[aCount].abilityVideo = hero + "/ability-translocator";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "HACK";
        abilities[aCount].abilityDescription = "Hold to hack. Hacked enemies cannot use abilities. Hacked health packs spawn faster but can't be used by enemies. Taking damage interrupts the hack attempt.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Hack";
        abilities[aCount].abilityVideo = hero + "/ability-hack";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "EMP";
        abilities[aCount].abilityDescription = "Hack enemies and destroy enemy shields and barriers around you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/EMP";
        abilities[aCount].abilityVideo = hero + "/ability-emp";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "OPPORTUNIST";
        abilities[aCount].abilityDescription = "You detect critically injured enemies through walls.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Opportunist";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].abilityDetails = new string[10];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

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