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
    public string abilityDetail = "";
    public string abilityVideo = "";
    public string abilityIcon = "";

    public int damage = 0;
    public int healing = 0;
    public int burst = 1;
    public int pellets = 1;
    public int ammo = 1;
    public int range = 10;

    public float reloadTime = 0.01f;
    public float recoverTime = 0.01f;

    public WeaponQualities[] weaponQualities = new WeaponQualities[] { WeaponQualities.None };

    public AbilityData()
    {
        
    }
}