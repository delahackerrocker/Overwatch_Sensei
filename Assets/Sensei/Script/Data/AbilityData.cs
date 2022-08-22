using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ControllerButton
{
    LeftBumper,
    LeftTrigger,
    RightBumper,
    RightTrigger,
    A,
    B,
    X,
    Y,
    DPadUp,
    DPadDown,
    DPadLeft,
    DPadRight,
    L3,
    R3,
    Passive,
    None
}

public enum WeaponQualities
{
    Melee,
    Hitscan,
    Projectile,
    Explosive,
    Beam,
    Shotgun,
    Linear,
    Arcing,
    SelfDamage,
    Pinpoint,
    Knockback,
    Spread,
    Healing,
    Aura,
    None
}

public class AbilityData
{
    public ControllerButton controllerButton = ControllerButton.Passive;

    public bool isUltimate = false;
    public int ultimateCharge = 0;

    public string abilityName = "";
    public string abilityDescription = "";
    public string abilityVideo = "";
    public string abilityIcon = "";

    public string[] abilityDetails;

    public int damage = 0;
    public int healing = 0;
    public int burst = 0;
    public int pellets = 0;
    public int ammo = 0;
    public int range = 0;
    public string projectileSpeed;
    public string duration;

    public float reloadTime = 0f;
    public float recoverTime = 0f;
    public float cooldown = 0f;
    public float castingTime = 0f;
    public float areaOfEffect = 0f;

    public WeaponQualities[] weaponQualities = new WeaponQualities[] { WeaponQualities.None };

    public AbilityData()
    {
        
    }
}