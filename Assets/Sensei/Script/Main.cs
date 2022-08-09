using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Singleton
    public static Main Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // ----

    public HERO_ID selectedHero = HERO_ID.None;
    public HERO_ID counterPick = HERO_ID.None;

    public AbilityData selectedAbility = null;

    public HeroData[] heroes = new HeroData[32];

    private void Start()
    {
        InitializeAllHeroData();
    }

    void InitializeAllHeroData()
    {
        int hCount = 0;
        int aCount = 0;

        // Ana
        heroes[hCount = 0] = new HeroData(HERO_ID.Ana, 200, 0, 0, Role.Support);
        heroes[hCount].description = "Ana’s versatile arsenal allows her to affect heroes all over the battlefield. Her Biotic Rifle rounds and Biotic Grenades heal allies and damage or impair enemies; her sidearm tranquilizes key targets, and Nano Boost gives one of her comrades a considerable increase in power.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC RIFLE";
        heroes[hCount].abilities[aCount].abilityDetail = "Long-range rifle that heals allies and damages enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ZOOM";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to zoom in.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SLEEP DART";
        heroes[hCount].abilities[aCount].abilityDetail = "Fires a dart that puts an enemy to sleep.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC GRENADE";
        heroes[hCount].abilities[aCount].abilityDetail = "Throws a grenade that heals and increases healing on allies, while damaging and preventing healing on enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "NANO BOOST";
        heroes[hCount].abilities[aCount].abilityDetail = "Increases an ally's damage, while reducing damage taken.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;


        // Ashe
        heroes[hCount = 1] = new HeroData(HERO_ID.Ashe, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Ashe quickly fires her rifle from the hip or uses her weapon’s aim-down sights to line up a high damage shot. She blasts enemies by throwing dynamite, and her coach gun packs enough punch to put some distance between her and her foes. And Ashe is not alone, as she can call on her omnic ally Bob, to join the fray when the need arises.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "THE VIPER";
        heroes[hCount].abilities[aCount].abilityDetail = "Semi-automatic rifle.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TAKE AIM";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to zoom in, increasing damage and accuracy but slowing rate of fire.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "COACH GUN";
        heroes[hCount].abilities[aCount].abilityDetail = "Blast enemies in front of you and knock yourself backwards.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DYNAMITE";
        heroes[hCount].abilities[aCount].abilityDetail = "Throw an explosive that detonates after a short delay or immediately when shot.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "B.O.B.";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy Bob. He charges forward and knocks enemies into the air, then attacks with his arm cannons.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Baptiste
        heroes[hCount = 2] = new HeroData(HERO_ID.Baptiste, 200, 0, 0, Role.Support);
        heroes[hCount].description = "Baptiste wields an assortment of experimental devices and weaponry to keep allies alive and eliminate threats under fierce conditions. A battle-hardened combat medic, he is just as capable of saving lives as he is taking out the enemy.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[7];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC LAUNCHER";
        heroes[hCount].abilities[aCount].abilityDetail = "Three-round burst gun.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC LAUNCHER";
        heroes[hCount].abilities[aCount].abilityDetail = "Lob a healing projectile that heals all allies near the impact.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "REGENERATIVE BURST";
        heroes[hCount].abilities[aCount].abilityDetail = "Activate to heal yourself and nearby allies over time.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "IMMORTALITY FIELD";
        heroes[hCount].abilities[aCount].abilityDetail = "Toss a device that prevents allies from dying. The device can be destroyed.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "AMPLIFICATION MATRIX";
        heroes[hCount].abilities[aCount].abilityDetail = "Project a matrix that doubles the damage and healing effects of allied projectiles.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "EXO BOOTS: CHARGE";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold crouch to charge your Exo Boots.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.B;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "EXO BOOTS: JUMP";
        heroes[hCount].abilities[aCount].abilityDetail = "Release the charge in your Exo Boots to increase the height of your jump. If there is no charge you will jump normally.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.A;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Bastion
        heroes[hCount = 3] = new HeroData(HERO_ID.Bastion, 200, 0, 100, Role.Damage);
        heroes[hCount].description = "Repair protocols and the ability to transform between stationary Assault, mobile Recon and devastating Tank configurations provide Bastion with a high probability of victory.";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CONFIGURATION: RECON";
        heroes[hCount].abilities[aCount].abilityDetail = "Mobile with a light automatic weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SELF-REPAIR";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to heal yourself.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RECONFIGURE";
        heroes[hCount].abilities[aCount].abilityDetail = "Switch between weapon configurations.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "";
        heroes[hCount].abilities[aCount].abilityDetail = "";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CONFIGURATION: TANK";
        heroes[hCount].abilities[aCount].abilityDetail = "Mobile with a powerful cannon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "IRONCLAD";
        heroes[hCount].abilities[aCount].abilityDetail = "Reduces damage taken while transformed.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Brigitte
        heroes[hCount = 4] = new HeroData(HERO_ID.Brigitte, 200, 0, 50, Role.Support);
        heroes[hCount].description = "Brigitte specializes in armor. She can throw Repair Packs to heal teammates, or automatically heal nearby allies when she damages foes with her Flail. Her Flail is capable of a wide swing to strike multiple targets, or a Whip Shot that stuns an enemy at range. When entering the fray, Barrier Shield provides personal defense while she attacks enemies with Shield Bash. Brigitte’s ultimate ability, Rally, gives her a substantial short-term boost of speed and provides long-lasting armor to all her nearby allies.";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ROCKET FLAIL";
        heroes[hCount].abilities[aCount].abilityDetail = "Melee weapon with extended range.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BARRIER SHIELD";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold Secondary Fire to deploy a frontal energy barrier.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "REPAIR PACK";
        heroes[hCount].abilities[aCount].abilityDetail = "Heals an ally for a short duration.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "WHIP SHOT";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch your flail forward to knock an enemy away from you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RALLY";
        heroes[hCount].abilities[aCount].abilityDetail = "Move faster and provide armor to nearby allies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "INSPIRE";
        heroes[hCount].abilities[aCount].abilityDetail = "Striking enemies with your flail heals nearby allies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Cassidy
        heroes[hCount = 5] = new HeroData(HERO_ID.Cassidy, 225, 0, 0, Role.Damage);
        heroes[hCount].description = "Armed with his Peacekeeper revolver, Cassidy takes out targets with deadeye precision and dives out of danger with eagle-like speed.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PEACEKEEPER";
        heroes[hCount].abilities[aCount].abilityDetail = "Accurate, powerful revolver.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FAN THE HAMMER";
        heroes[hCount].abilities[aCount].abilityDetail = "Wildly fire remaining rounds.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "COMBAT ROLL";
        heroes[hCount].abilities[aCount].abilityDetail = "Roll in the direction you're moving and reload.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FLASHBANG";
        heroes[hCount].abilities[aCount].abilityDetail = "Stun enemies in front of you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DEADEYE";
        heroes[hCount].abilities[aCount].abilityDetail = "Face off against your enemies. Press Q to lock on, then Q or ABILITY 3 to fire.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // DVa
        heroes[hCount = 6] = new HeroData(HERO_ID.DVa, 300, 300, 0, Role.Tank);
        heroes[hCount].description = "D.Va’s mech is nimble and powerful—its twin Fusion Cannons blast away with autofire at short range, and she can use its Boosters to barrel over enemies and obstacles, or deflect attacks with her projectile-dismantling Defense Matrix.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FUSION CANNONS";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatic short-range spread weapons.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DEFENSE MATRIX";
        heroes[hCount].abilities[aCount].abilityDetail = "Block projectiles in an area in front of you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BOOSTERS";
        heroes[hCount].abilities[aCount].abilityDetail = "Fly in the direction you are facing.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "MICRO MISSILES";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a volley of explosive rockets.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SELF - DESTRUCT";
        heroes[hCount].abilities[aCount].abilityDetail = "Eject and overload your mech, causing it to explode after a short time.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "EJECT!";
        heroes[hCount].abilities[aCount].abilityDetail = "Eject out of your mech when it is destroyed.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Doomfist
        heroes[hCount = 7] = new HeroData(HERO_ID.Doomfist, 250, 0, 0, Role.Damage);
        heroes[hCount].description = "Doomfist’s cybernetics make him a highly-mobile, powerful frontline fighter. In addition to dealing ranged damage with his Hand Cannon, Doomfist can slam the ground, knock enemies into the air and off balance, or charge into the fray with his Rocket Punch. When facing a tightly packed group, Doomfist leaps out of view, then crashes down to earth with a spectacular Meteor Strike.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HAND CANNON";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range weapon with spread. Reloads automatically.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SEISMIC SLAM";
        heroes[hCount].abilities[aCount].abilityDetail = "Leap forward and smash the ground.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RISING UPPERCUT";
        heroes[hCount].abilities[aCount].abilityDetail = "Knock an enemy into the air.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ROCKET PUNCH";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to charge then release to launch forward and knock an enemy back. Damage increases if the enemy hits a wall.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "METEOR STRIKE";
        heroes[hCount].abilities[aCount].abilityDetail = "Press Q to leap up into the air. Move the targeting circle, then press ABILITY 3 to strike the targeted area.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "THE BEST DEFENSE...";
        heroes[hCount].abilities[aCount].abilityDetail = "Dealing damage with abilities creates temporary personal shields.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Echo
        heroes[hCount = 8] = new HeroData(HERO_ID.Echo, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Echo is an evolutionary robot programmed with a rapidly adapting artificial intelligence, versatile enough to fill multiple battlefield combat roles.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TRI-SHOT";
        heroes[hCount].abilities[aCount].abilityDetail = "Fires 3 shots at once, in a triangle pattern.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "STICKY BOMBS";
        heroes[hCount].abilities[aCount].abilityDetail = "Fire a volley of sticky bombs that detonate after a delay.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FOCUSING BEAM";
        heroes[hCount].abilities[aCount].abilityDetail = "Channel a beam for a few seconds. Deals very high damage to targets under half health.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FLIGHT";
        heroes[hCount].abilities[aCount].abilityDetail = "Fly forward quickly and then free-fly briefly.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DUPLICATE";
        heroes[hCount].abilities[aCount].abilityDetail = "Become a copy of the targeted enemy hero. They cannot swap heroes for the duration.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "GLIDE";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold jump to glide while falling.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Genji
        heroes[hCount = 9] = new HeroData(HERO_ID.Genji, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Genji flings precise and deadly Shuriken at his targets, and uses his technologically-advanced katana to deflect projectiles or deliver a Swift Strike that cuts down enemies.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SHURIKEN";
        heroes[hCount].abilities[aCount].abilityDetail = "Throw an accurate burst of 3 projectiles.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FAN OF BLADES";
        heroes[hCount].abilities[aCount].abilityDetail = "Throw a fan of 3 projectiles in an arc.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DEFLECT";
        heroes[hCount].abilities[aCount].abilityDetail = "Deflect incoming projectiles towards the direction you are aiming and block melee attacks.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SWIFT STRIKE";
        heroes[hCount].abilities[aCount].abilityDetail = "Rapidly dash forward and inflict damage on enemies. Eliminations reset the cooldown.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DRAGON BLADE";
        heroes[hCount].abilities[aCount].abilityDetail = "Unsheathe a deadly melee weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CYBER AGILITY";
        heroes[hCount].abilities[aCount].abilityDetail = "Unsheathe a deadly melee weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Hanzo
        heroes[hCount = 10] = new HeroData(HERO_ID.Hanzo, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Hanzo’s versatile arrows can reveal his enemies or fragment to strike multiple targets. He can scale walls to fire his bow from on high, or summon a titanic spirit dragon.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "STORM BOW";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to charge then release to launch arrows further.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "STORM ARROWS";
        heroes[hCount].abilities[aCount].abilityDetail = "The next 5 arrows fire instantly at reduced damage.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SONIC ARROW";
        heroes[hCount].abilities[aCount].abilityDetail = "Reveals enemies for a short time upon impact.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "LUNGE";
        heroes[hCount].abilities[aCount].abilityDetail = "Double Jump.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.A;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DRAGON STRIKE";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a deadly Dragon Spirit that devastates enemies it passes through.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "WALL CLIMB";
        heroes[hCount].abilities[aCount].abilityDetail = "Jump at walls to climb up them.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Junkrat
        heroes[hCount = 11] = new HeroData(HERO_ID.Junkrat, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Junkrat’s area-denying armaments include a Frag Launcher that lobs bouncing grenades, Concussion Mines that send enemies flying, and Steel Traps that stop foes dead in their tracks.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FRAG LAUNCHER";
        heroes[hCount].abilities[aCount].abilityDetail = "Bouncing explosive projectile weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CONCUSSION MINE";
        heroes[hCount].abilities[aCount].abilityDetail = "Throw a knockback mine with LSHIFT then detonate it with ABILITY 1.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "STEEL TRAP";
        heroes[hCount].abilities[aCount].abilityDetail = "Place an immobilizing trap.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RIP-TIRE";
        heroes[hCount].abilities[aCount].abilityDetail = "Drive and detonate an exploding tire.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TOTAL MAYHEM";
        heroes[hCount].abilities[aCount].abilityDetail = "Deals no damage to self with explosives. Drop bombs on death.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Lucio
        heroes[hCount = 12] = new HeroData(HERO_ID.Lucio, 200, 0, 0, Role.Support);
        heroes[hCount].description = "On the battlefield, Lúcio’s cutting-edge Sonic Amplifier buffets enemies with projectiles and knocks foes back with blasts of sound. His songs can both heal his team or boost their movement speed, and he can switch between tracks on the fly.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SONIC AMPLIFIER";
        heroes[hCount].abilities[aCount].abilityDetail = "Sonic projectile launcher.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SOUNDWAVE";
        heroes[hCount].abilities[aCount].abilityDetail = "Create a short-range blast wave to knock enemies away from you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "AMP IT UP";
        heroes[hCount].abilities[aCount].abilityDetail = "Increase the effectiveness of your current song.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CROSSFADE";
        heroes[hCount].abilities[aCount].abilityDetail = "Switches between two songs: Healing Boost heals nearby allies, and Speed Boost makes nearby allies move faster.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SOUND BARRIER";
        heroes[hCount].abilities[aCount].abilityDetail = "Create temporary shields for nearby allies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "WALL RIDE";
        heroes[hCount].abilities[aCount].abilityDetail = "Jump onto a wall to ride along it.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.A;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Mei
        heroes[hCount = 13] = new HeroData(HERO_ID.Mei, 250, 0, 0, Role.Damage);
        heroes[hCount].description = "Mei’s weather-altering devices slow opponents and protect locations. Her Endothermic Blaster unleashes damaging icicles and frost streams, and she can Cryo-Freeze herself to guard against counterattacks, or obstruct the opposing team's movements with an Ice Wall.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ENDOTHERMIC BLASTER";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range spray weapon that freezes.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ICICLE";
        heroes[hCount].abilities[aCount].abilityDetail = "Long-range icicle launcher.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CRYO-FREEZE";
        heroes[hCount].abilities[aCount].abilityDetail = "Become invulnerable and heal yourself.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ICE WALL";
        heroes[hCount].abilities[aCount].abilityDetail = "Create a wall in front of you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BLIZZARD";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a weather control drone that freezes enemies in a wide area.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Mercy
        heroes[hCount = 14] = new HeroData(HERO_ID.Mercy, 200, 0, 0, Role.Support);
        heroes[hCount].description = "";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[7];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CADUCEUS STAFF";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to heal an ally.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CADUCEUS BLASTER";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatic weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.DPadRight;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CADUCEUS STAFF";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to increase an ally's damage inflicted.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RESURRECT";
        heroes[hCount].abilities[aCount].abilityDetail = "Revive a dead teammate.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ANGELIC DESCENT";
        heroes[hCount].abilities[aCount].abilityDetail = "Fall very slowly.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.A;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "VALKYRIE";
        heroes[hCount].abilities[aCount].abilityDetail = "Gain the ability to fly. Abilities are enhanced.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "REGENERATION";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatically heal over time.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Moira
        heroes[hCount = 15] = new HeroData(HERO_ID.Moira, 200, 0, 0, Role.Support);
        heroes[hCount].description = "Moira’s biotic abilities enable her to contribute healing or damage in any crisis. While Biotic Grasp gives Moira short-range options, her Biotic Orbs contribute longer-range, hands-off damage and healing; she can also Fade to escape groups or remain close to allies in need of support. Once she’s charged Coalescence, Moira can save multiple allies from elimination at once or finish off weakened enemies.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC GRASP";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to heal all allies in front of you. Consumes biotic energy.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC GRASP - ALT FIRE";
        heroes[hCount].abilities[aCount].abilityDetail = "Long range beam weapon. Damage dealt heals you and replenishes your biotic energy.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FADE";
        heroes[hCount].abilities[aCount].abilityDetail = "Disappear, move faster, and become invulnerable, but you cannot shoot.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC ORB";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a bouncing sphere that either heals nearby allies or damages nearby enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "COALESCENCE";
        heroes[hCount].abilities[aCount].abilityDetail = "Fire a beam that heals allies and damages enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Orisa
        heroes[hCount = 16] = new HeroData(HERO_ID.Orisa, 200, 0, 250, Role.Tank);
        heroes[hCount].description = "";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FUSION DRIVER";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatic projectile weapon. Slows Orisa while firing.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PROTECTIVE BARRIER";
        heroes[hCount].abilities[aCount].abilityDetail = "Throw a device that creates a barrier.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FORTIFY";
        heroes[hCount].abilities[aCount].abilityDetail = "Reduce damage taken and you cannot be stopped.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HALT!";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a graviton charge with Secondary Fire then detonate it with SECONDARY FIRE. The sphere slows and pulls nearby enemies to it.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SUPERCHARGER";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy a device that increases damage inflicted by your allies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Pharah
        heroes[hCount = 17] = new HeroData(HERO_ID.Pharah, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Soaring through the air in her combat armor, and armed with a launcher that lays down high-explosive rockets, Pharah is a force to be reckoned with.";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ROCKET LAUNCHER";
        heroes[hCount].abilities[aCount].abilityDetail = "Long-range explosive projectile weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HOVER JETS";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to hover.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.A;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CONCUSSIVE BLAST";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch an explosive blast to knock back enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "JUMP JET";
        heroes[hCount].abilities[aCount].abilityDetail = "Fly rapidly upwards.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BARRAGE";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a continuous volley of mini-rockets.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Reaper
        heroes[hCount = 18] = new HeroData(HERO_ID.Reaper, 250, 0, 0, Role.Damage);
        heroes[hCount].description = "Hellfire Shotguns, the ghostly ability to become immune to damage, and the power to step between shadows make Reaper one of the deadliest beings on Earth.";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HELLFIRE SHOTGUNS";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range spread weapons.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "WRAITH FORM";
        heroes[hCount].abilities[aCount].abilityDetail = "Move faster and become invulnerable, but you cannot shoot.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SHADOW STEP";
        heroes[hCount].abilities[aCount].abilityDetail = "Teleport to a targeted location.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "THE REAPING";
        heroes[hCount].abilities[aCount].abilityDetail = "Dealing damage heals you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DEATH BLOSSOM";
        heroes[hCount].abilities[aCount].abilityDetail = "Damage all nearby enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Reinhardt
        heroes[hCount = 19] = new HeroData(HERO_ID.Reinhardt, 300, 200, 0, Role.Tank);
        heroes[hCount].description = "Clad in powered armor and swinging his hammer, Reinhardt leads a rocket-propelled charge across the battleground and defends his squadmates with a massive energy barrier.";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ROCKET HAMMER";
        heroes[hCount].abilities[aCount].abilityDetail = "Devastating melee weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BARRIER FIELD";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold Secondary Fire to deploy a frontal energy barrier.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CHARGE";
        heroes[hCount].abilities[aCount].abilityDetail = "Charge forward and smash an enemy against a wall.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FIRE STRIKE";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a fiery projectile.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "EARTHSHATTER";
        heroes[hCount].abilities[aCount].abilityDetail = "Knock down all enemies in front of you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "STEADFAST";
        heroes[hCount].abilities[aCount].abilityDetail = "Resistant to knock back effects.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Roadhog
        heroes[hCount = 20] = new HeroData(HERO_ID.Roadhog, 600, 0, 0, Role.Tank);
        heroes[hCount].description = "Roadhog uses his signature Chain Hook to pull his enemies close before shredding them with blasts from his Scrap Gun. He’s hardy enough to withstand tremendous damage, and can recover his health with a short breather.";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SCRAP GUN";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range spread weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SCRAP GUN";
        heroes[hCount].abilities[aCount].abilityDetail = "Medium-range spread weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "CHAIN HOOK";
        heroes[hCount].abilities[aCount].abilityDetail = "Drag a targeted enemy to you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TAKE A BREATHER";
        heroes[hCount].abilities[aCount].abilityDetail = "Heal yourself and reduce damage taken over a short time.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "WHOLE HOG";
        heroes[hCount].abilities[aCount].abilityDetail = "Damage and knock back enemies in front of you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Sigma
        heroes[hCount = 21] = new HeroData(HERO_ID.Sigma, 300, 100, 0, Role.Tank);
        heroes[hCount].description = "Sigma is an eccentric astrophysicist and volatile tank who gained the power to control gravity in an orbital experiment gone wrong. Manipulated by Talon and deployed as a living weapon, Sigma’s presence on the battlefield cannot be ignored.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HYPERSPHERES";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch two charges which implode after a short duration, dealing damage in an area.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "EXPERIMENTAL BARRIER";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to propel a floating barrier; release to stop. Press again to recall the barrier to you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ACCRETION";
        heroes[hCount].abilities[aCount].abilityDetail = "Gather a mass of debris and throw it at an enemy to knock them down.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "KINETIC GRASP";
        heroes[hCount].abilities[aCount].abilityDetail = "Absorb projectiles in front of you and convert them into shields.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "GRAVITIC FLUX";
        heroes[hCount].abilities[aCount].abilityDetail = "Manipulate gravity to lift enemies into the air and slam them back down.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Soldier76
        heroes[hCount = 22] = new HeroData(HERO_ID.Soldier76, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Armed with cutting-edge weaponry, including an experimental pulse rifle that’s capable of firing spirals of high-powered Helix Rockets, Soldier: 76 has the speed and support know-how of a highly trained warrior.";
        heroes[hCount].stars = 1;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HEAVY PULSE RIFLE";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatic assault weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HELIX ROCKETS";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a volley of explosive rockets.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BIOTIC FIELD";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy a field that heals you and your allies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SPRINT";
        heroes[hCount].abilities[aCount].abilityDetail = "Run faster while moving forward.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TACTICAL VISOR";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatically aims your weapon at targets in view.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Sombra
        heroes[hCount = 23] = new HeroData(HERO_ID.Sombra, 200, 0, 0, Role.Damage);
        heroes[hCount].description = "Stealth and debilitating attacks make Sombra a powerful infiltrator. Her hacking can disrupt her enemies, ensuring they're easier to take out, while her EMP provides the upper hand against multiple foes at once. Sombra’s ability to Translocate and camouflage herself makes her a hard target to pin down.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "MACHINE PISTOL";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range automatic weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "STEALTH";
        heroes[hCount].abilities[aCount].abilityDetail = "Become invisible and move quickly.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TRANSLOCATOR";
        heroes[hCount].abilities[aCount].abilityDetail = "Throw a beacon, then press E again to teleport to it. Press ABILITY 2 to remove it.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "HACK";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to hack. Hacked enemies cannot use abilities. Hacked health packs spawn faster but can't be used by enemies. Taking damage interrupts the hack attempt.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "EMP";
        heroes[hCount].abilities[aCount].abilityDetail = "Hack enemies and destroy enemy shields and barriers around you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "OPPORTUNIST";
        heroes[hCount].abilities[aCount].abilityDetail = "You detect critically injured enemies through walls.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Symmetra
        heroes[hCount = 24] = new HeroData(HERO_ID.Symmetra, 100, 125, 0, Role.Damage);
        heroes[hCount].description = "Symmetra utilizes her Photon Projector to dispatch adversaries, shield her associates, construct teleportation pads and deploy particle-blasting Sentry Turrets.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PHOTON PROJECTOR";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range beam weapon with increasing damage. Damaging Barriers does not consume ammunition.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PHOTON PROJECTOR";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold to charge, release to fire explosive orb.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TELEPORTER";
        heroes[hCount].abilities[aCount].abilityDetail = "Create two teleporters that enable instant travel between them.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SENTRY TURRET";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy a small turret that damages and slows enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PHOTON BARRIER";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy a massive energy barrier.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Torbjorn
        heroes[hCount = 25] = new HeroData(HERO_ID.Torbjorn, 200, 0, 50, Role.Damage);
        heroes[hCount].description = "";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RIVET GUN";
        heroes[hCount].abilities[aCount].abilityDetail = "Slow firing, long-ranged weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RIVET GUN - ALT FIRE";
        heroes[hCount].abilities[aCount].abilityDetail = "Inaccurate but powerful short-range weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "FORGE HAMMER";
        heroes[hCount].abilities[aCount].abilityDetail = "Swing to repair your turret or damage an enemy.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.DPadLeft;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "OVERLOAD";
        heroes[hCount].abilities[aCount].abilityDetail = "Gain additional armor as well as improved attack, movement, and reload speed.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "DEPLOY TURRET";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy a self-building turret.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "MOLTEN CORE";
        heroes[hCount].abilities[aCount].abilityDetail = "Create pools of molten slag that damage enemies. Deals additional damage to armor.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Tracer
        heroes[hCount = 26] = new HeroData(HERO_ID.Tracer, 150, 0, 0, Role.Damage);
        heroes[hCount].description = "Toting twin pulse pistols, energy-based time bombs, and rapid-fire banter, Tracer is able to 'blink' through space and rewind her personal timeline as she battles to right wrongs the world over.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PULSE PISTOLS";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range automatic weapons.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BLINK";
        heroes[hCount].abilities[aCount].abilityDetail = "Teleport in the direction you are moving.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RECALL";
        heroes[hCount].abilities[aCount].abilityDetail = "Travel back in time to your previous location and health.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "RECALL";
        heroes[hCount].abilities[aCount].abilityDetail = "Travel back in time to your previous location and health.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PULSE BOMB";
        heroes[hCount].abilities[aCount].abilityDetail = "Throw out a powerful sticky explosive.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Widowmaker
        heroes[hCount = 27] = new HeroData(HERO_ID.Widowmaker, 175, 0, 0, Role.Damage);
        heroes[hCount].description = "Widowmaker equips herself with whatever it takes to eliminate her targets, including mines that dispense poisonous gas, a visor that grants her squad infra-sight, and a powerful sniper rifle that can fire in fully-automatic mode.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "WIDOW'S KISS";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatic assault weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "SNIPER MODE";
        heroes[hCount].abilities[aCount].abilityDetail = "Hold for long-ranged sniper weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "VENOM MINE";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a poison trap.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "GRAPPLING HOOK";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a hook that pulls you towards a ledge.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "INFRA-SIGHT";
        heroes[hCount].abilities[aCount].abilityDetail = "Provide your team with a view of the enemy's location.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Winston
        heroes[hCount = 28] = new HeroData(HERO_ID.Winston, 400, 0, 150, Role.Tank);
        heroes[hCount].description = "Winston wields impressive inventions—a jump pack, electricity-blasting Tesla Cannon, portable shield projector and more—with literal gorilla strength.";
        heroes[hCount].stars = 2;

        heroes[hCount].abilities = new AbilityData[4];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TESLA CANNON";
        heroes[hCount].abilities[aCount].abilityDetail = "Electric frontal-cone weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "BARRIER PROJECTOR";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy a protective energy dome.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "JUMP PACK";
        heroes[hCount].abilities[aCount].abilityDetail = "Leap forward into the air. Landing on an enemy damages them.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PRIMAL RAGE";
        heroes[hCount].abilities[aCount].abilityDetail = "Gain immense health, but you can only leap and punch enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // WreckingBall
        heroes[hCount = 29] = new HeroData(HERO_ID.WreckingBall, 500, 0, 100, Role.Tank);
        heroes[hCount].description = "Wrecking Ball rolls across the battlefield, using his arsenal of weapons and his mech’s powerful body to crush his enemies.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "QUAD CANNONS";
        heroes[hCount].abilities[aCount].abilityDetail = "Automatic assault weapons.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ROLL";
        heroes[hCount].abilities[aCount].abilityDetail = "Transform into a ball and increase maximum movement speed.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ADAPTIVE SHIELD";
        heroes[hCount].abilities[aCount].abilityDetail = "Create temporary personal shields. Amount increases with more enemies nearby.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "GRAPPLING CLAW";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a grappling claw to rapidly swing around the area. Enables high speed collisions to damage and knockback enemies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "MINEFIELD";
        heroes[hCount].abilities[aCount].abilityDetail = "Deploy a massive field of proximity mines.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Zarya
        heroes[hCount = 30] = new HeroData(HERO_ID.Zarya, 200, 200, 0, Role.Tank);
        heroes[hCount].description = "Deploying powerful personal barriers that convert incoming damage into energy for her massive Particle Cannon, Zarya is an invaluable asset on the front lines of any battle.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[6];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PARTICLE CANNON";
        heroes[hCount].abilities[aCount].abilityDetail = "Short-range linear beam weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PARTICLE CANNON";
        heroes[hCount].abilities[aCount].abilityDetail = "Energy grenade launcher.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PROJECTED BARRIER";
        heroes[hCount].abilities[aCount].abilityDetail = "Create a damage barrier around an ally.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "PARTICLE BARRIER";
        heroes[hCount].abilities[aCount].abilityDetail = "Create a damage barrier around you.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "GRAVITON SURGE";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch a gravity well that pulls enemies to it.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ENERGY";
        heroes[hCount].abilities[aCount].abilityDetail = "Damage blocked by barriers increases Particle Cannon damage.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Passive;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;

        // Zenyatta
        heroes[hCount = 31] = new HeroData(HERO_ID.Zenyatta, 50, 150, 0, Role.Support);
        heroes[hCount].description = "Zenyatta calls upon orbs of harmony and discord to heal his teammates and weaken his opponents, all while pursuing a transcendent state of immunity to damage.";
        heroes[hCount].stars = 3;

        heroes[hCount].abilities = new AbilityData[5];
        heroes[hCount].abilities[aCount = 0] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ORB OF DESTRUCTION";
        heroes[hCount].abilities[aCount].abilityDetail = "Energy projectile weapon.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ORB OF DESTRUCTION";
        heroes[hCount].abilities[aCount].abilityDetail = "Charge to release more projectiles.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftTrigger;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ORB OF HARMONY";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch this orb at an ally to heal them.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.RightBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "ORB OF DISCORD";
        heroes[hCount].abilities[aCount].abilityDetail = "Launch this orb at an enemy to increase the damage they take.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.LeftBumper;

        heroes[hCount].abilities[++aCount] = new AbilityData();
        heroes[hCount].abilities[aCount].abilityName = "TRANSCENDENCE";
        heroes[hCount].abilities[aCount].abilityDetail = "Become invulnerable, move faster, and heal nearby allies.";
        heroes[hCount].abilities[aCount].controllerButton = ControllerButton.Y;

        heroes[hCount].strongAgainst = new HERO_ID[8];
        heroes[hCount].strongAgainst[0] = HERO_ID.Ana;
        heroes[hCount].strongAgainst[1] = HERO_ID.Ashe;
        heroes[hCount].strongAgainst[2] = HERO_ID.Baptiste;
        heroes[hCount].strongAgainst[3] = HERO_ID.Bastion;
        heroes[hCount].strongAgainst[4] = HERO_ID.Brigitte;
        heroes[hCount].strongAgainst[5] = HERO_ID.Cassidy;
        heroes[hCount].strongAgainst[6] = HERO_ID.Doomfist;
        heroes[hCount].strongAgainst[7] = HERO_ID.DVa;

        heroes[hCount].weakAgainst = new HERO_ID[8];
        heroes[hCount].weakAgainst[0] = HERO_ID.Echo;
        heroes[hCount].weakAgainst[1] = HERO_ID.Genji;
        heroes[hCount].weakAgainst[2] = HERO_ID.Hanzo;
        heroes[hCount].weakAgainst[3] = HERO_ID.Junkrat;
        heroes[hCount].weakAgainst[4] = HERO_ID.Lucio;
        heroes[hCount].weakAgainst[5] = HERO_ID.Mei;
        heroes[hCount].weakAgainst[6] = HERO_ID.Mercy;
        heroes[hCount].weakAgainst[7] = HERO_ID.Moira;
    }
}