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

        description = "On the battlefield, L?cio?s cutting-edge Sonic Amplifier buffets enemies with projectiles and knocks foes back with blasts of sound. His songs can both heal his team or boost their movement speed, and he can switch between tracks on the fly.";
        stars = 2;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "SONIC AMPLIFIER";
        abilities[aCount].abilityDescription = "L?cio can hit his enemies with sonic projectiles.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SonicAmplifier";
        abilities[aCount].abilityVideo = hero + "/ability-sonic-amplifier";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].abilityDetails = new string[7];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 4-round-burst\n               20 per round";
        abilities[aCount].abilityDetails[++bCount] = "<b>Spread Angle:</b> Pinpoint";
        abilities[aCount].abilityDetails[++bCount] = "<b>Projectile Speed:</b> 50 mps";
        abilities[aCount].abilityDetails[++bCount] = "<b>Rate of Fire:</b> 1 burst per 0.92 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ammo:</b> 20";
        abilities[aCount].abilityDetails[++bCount] = "<b>Reload Time:</b> 1.5 seconds animation";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SOUNDWAVE";
        abilities[aCount].abilityDescription = "Create a short-range blast wave to knock enemies away from you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SoundWave";
        abilities[aCount].abilityVideo = hero + "/ability-soundwave";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].abilityDetails = new string[6];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Damage:</b> 25";
        abilities[aCount].abilityDetails[++bCount] = "<b>Max Range:</b> 8 meters";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.56 s. recovery for primary";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 4 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Headshot:</b> Yes";
        abilities[aCount].abilityDetails[++bCount] = "\nCan be used while reloading.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "AMP IT UP";
        abilities[aCount].abilityDescription = "L?cio increases the volume on his speakers, boosting the effects of his songs.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/AmpItUp";
        abilities[aCount].abilityVideo = hero + "/ability-amp-it-up";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> Allies: 52 per second\n             Self: 40 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +60% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 12 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 3 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Cooldown:</b> 12 seconds";
        abilities[aCount].abilityDetails[++bCount] = "\nThe cooldown starts after the ability duration ends.";
        abilities[aCount].abilityDetails[++bCount] = "\nUpon activation, there is 0.69 second recovery period where Lucio cannot use his weapon or ability.";
        abilities[aCount].abilityDetails[++bCount] = "\nThere is an unpleasant bug in the game due to which if you are hacked by Sombra during the active ability, it will go on cooldown only after cast timt ends.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "CROSSFADE";
        abilities[aCount].abilityDescription = "Switches between two songs: Healing Boost heals nearby allies, and Speed Boost makes nearby allies move faster.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/CrossFade";
        abilities[aCount].abilityVideo = hero + "/ability-crossfade";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Healing:</b> Allies: 16 per second\n             Self: 12 per second";
        abilities[aCount].abilityDetails[++bCount] = "<b>Move. Speed:</b> +25% buff";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 12 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.8 second animation duration";
        abilities[aCount].abilityDetails[++bCount] = "\nBoth songs require line of sight and does not affect allies behind enemy barriers.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf a teammate leaves the area, the current song effect lingers for 1 second, unless the song is switched.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe switch can be done while reloading.";
        abilities[aCount].abilityDetails[++bCount] = "\nThe aura of speed affects the speed of movement on the surface and walls. Enabling/disabling it while flying does not affect speed unless your speed is greater than 11 m/s.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "SOUND BARRIER";
        abilities[aCount].abilityDescription = "Protective waves radiate out from L?cio?s Sonic Amplifier, briefly providing him and nearby allies with personal shields.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/SoundBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-sound-barrier";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].abilityDetails = new string[9];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Health:</b> 750 temporary shields";
        abilities[aCount].abilityDetails[++bCount] = "<b>Area of Effect:</b> 30 meter radius";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> 0.72 s. from flat ground + 0.83 s. recovery";
        abilities[aCount].abilityDetails[++bCount] = "<b>Duration:</b> 7 seconds";
        abilities[aCount].abilityDetails[++bCount] = "<b>Ultimate Cost:</b> 2940 points";
        abilities[aCount].abilityDetails[++bCount] = "\nGives L?cio and all allies in his line of sight a huge burst of temporary shields that immediately decay at 125 shields per second (12 shields every 0.096 s).";
        abilities[aCount].abilityDetails[++bCount] = "\nWhen cast, L?cio does a small leap before applying his ult, making it more effective to cast it from low to high ground (like a payload or ledge) or close to a low ceiling (like a small doorway) to decrease cast time.";
        abilities[aCount].abilityDetails[++bCount] = "\nAfter fully cast, has approximately 0.83 seconds of 'grace period' where the ultimate can still be applied to allies that have not received personal shields if they come in range.";
        abilities[aCount].abilityDetails[++bCount] = "\nDoes not affect allies behind enemy barriers.";

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "WALL RIDE";
        abilities[aCount].abilityDescription = "Jump onto a wall to ride along it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/WallRide";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.A;
        abilities[aCount].abilityDetails = new string[8];
        abilities[aCount].abilityDetails[bCount = 0] = "<b>Move. Speed:</b> +30% buff +2.5 mps (wall leap)";
        abilities[aCount].abilityDetails[++bCount] = "<b>Casting Time:</b> instantly + 0.5 s. recovery for reuse";
        abilities[aCount].abilityDetails[++bCount] = "\nIf Wall Jump On Release is enabled, then while on a wall, you can press crouch to fall off it without making a jump.";
        abilities[aCount].abilityDetails[++bCount] = "\nTo start a Wall Ride, jump at a nearby wall and hold the Jump key. L?cio will Wall Ride as long as it is held.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf the option 'Allow Backwards Wall Ride' is enabled, L?cio will be able to start a Wall Ride midair without needing to look at the wall or needing to move prior to Wall Riding.";
        abilities[aCount].abilityDetails[++bCount] = "\nUnlike most heroes, Lucio's speed does not decrease while flying. However, if its speed is greater than 13.8 m/s with the speed aura enabled (17.6 m/s if Amp It Up), or 11.0 with heal aura, the speed will decrease by ~1m/s until it returns to the desired value.";
        abilities[aCount].abilityDetails[++bCount] = "\nWhen looking down while wall riding and holding forward to press jump, Lucio will jump up at a speed of 4.12 m/s. If you look up, then the speed will be 9.12 m/s.";
        abilities[aCount].abilityDetails[++bCount] = "\nIf you look straight ahead during a wall ride and press jump, Lucio will jump up at a speed of 6.54 m/s. By holding forward in advance, you can increase the speed to 6.9 m/s.";

        strongAgainst = new HERO_ID[0];

        weakAgainst = new HERO_ID[7];
        weakAgainst[0] = HERO_ID.Ana;
        weakAgainst[1] = HERO_ID.Cassidy;
        weakAgainst[2] = HERO_ID.Pharah;
        weakAgainst[3] = HERO_ID.Symmetra;
        weakAgainst[4] = HERO_ID.Roadhog;
        weakAgainst[5] = HERO_ID.Sombra;
        weakAgainst[6] = HERO_ID.Winston;
    }
}