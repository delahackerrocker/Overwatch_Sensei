using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LucioHD : HeroData
{
    public LucioHD() : base()
    {
        this.hero = HERO_ID.Lucio;
        this.health = 200;
        this.shields = 0;
        this.armor = 0;
        this.role = Role.Support;

        int aCount = 0;
        int bCount = 0;

        description = "On the battlefield, Lúcio’s cutting-edge Sonic Amplifier buffets enemies with projectiles and knocks foes back with blasts of sound. His songs can both heal his team or boost their movement speed, and he can switch between tracks on the fly.";
        stars = 2;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "SONIC AMPLIFIER";
        abilities[aCount].abilityDescription = "Sonic projectile launcher.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SonicAmplifier";
        abilities[aCount].abilityVideo = hero + "/ability-sonic-amplifier";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SOUNDWAVE";
        abilities[aCount].abilityDescription = "Create a short-range blast wave to knock enemies away from you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SoundWave";
        abilities[aCount].abilityVideo = hero + "/ability-soundwave";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "AMP IT UP";
        abilities[aCount].abilityDescription = "Increase the effectiveness of your current song.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AmpItUp";
        abilities[aCount].abilityVideo = hero + "/ability-amp-it-up";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CROSSFADE";
        abilities[aCount].abilityDescription = "Switches between two songs: Healing Boost heals nearby allies, and Speed Boost makes nearby allies move faster.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CrossFade";
        abilities[aCount].abilityVideo = hero + "/ability-crossfade";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SOUND BARRIER";
        abilities[aCount].abilityDescription = "Create temporary shields for nearby allies.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SoundBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-sound-barrier";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
        abilities[aCount].abilityDetails[++bCount] = "";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WALL RIDE";
        abilities[aCount].abilityDescription = "Jump onto a wall to ride along it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WallRide";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[2];
        abilities[aCount].abilityDetails[bCount = 0] = "";
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