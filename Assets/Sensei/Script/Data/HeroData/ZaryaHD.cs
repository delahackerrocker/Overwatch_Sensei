using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZaryaHD : HeroData
{
    public ZaryaHD() : base()
    {
        this.hero = HERO_ID.Zarya;
        this.health = 200;
        this.shields = 200;
        this.armor = 0;
        this.role = Role.Tank;

        int aCount = 0;

        description = "Deploying powerful personal barriers that convert incoming damage into energy for her massive Particle Cannon, Zarya is an invaluable asset on the front lines of any battle.";
        stars = 3;

        abilities = new AbilityData[6];
        abilities[aCount = 0] = new AbilityData();
        abilities[aCount].abilityName = "PARTICLE CANNON";
        abilities[aCount].abilityDetail = "Short-range linear beam weapon.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ParticleCannon";
        abilities[aCount].abilityVideo = hero + "/ability-particle-cannon";
        abilities[aCount].controllerButton = ControllerButton.RightTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PARTICLE CANNON";
        abilities[aCount].abilityDetail = "Energy grenade launcher.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ParticleCannon";
        abilities[aCount].abilityVideo = hero + "/ability-particle-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftTrigger;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PROJECTED BARRIER";
        abilities[aCount].abilityDetail = "Create a damage barrier around an ally.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ProjectedBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-projected-barrier";
        abilities[aCount].controllerButton = ControllerButton.RightBumper;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "PARTICLE BARRIER";
        abilities[aCount].abilityDetail = "Create a damage barrier around you.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/ParticleBarrier";
        abilities[aCount].abilityVideo = hero + "/ability-particle-barrier";
        abilities[aCount].controllerButton = ControllerButton.LeftBumper;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "GRAVITON SURGE";
        abilities[aCount].abilityDetail = "Launch a gravity well that pulls enemies to it.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/GravitonSurge";
        abilities[aCount].abilityVideo = hero + "/ability-graviton-surge";
        abilities[aCount].controllerButton = ControllerButton.Y;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

        abilities[++aCount] = new AbilityData();
        abilities[aCount].abilityName = "ENERGY";
        abilities[aCount].abilityDetail = "Damage blocked by barriers increases Particle Cannon damage.";
        abilities[aCount].abilityIcon = "Heroes/AbilityIcons/" + hero + "/Energy";
        abilities[aCount].abilityVideo = hero + "/intro-video";
        abilities[aCount].controllerButton = ControllerButton.Passive;
        abilities[aCount].damage = 0;
        abilities[aCount].healing = 0;
        abilities[aCount].burst = 1;
        abilities[aCount].pellets = 1;
        abilities[aCount].ammo = 1;
        abilities[aCount].range = 10;
        abilities[aCount].reloadTime = 0.01f;
        abilities[aCount].recoverTime = 0.01f;

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