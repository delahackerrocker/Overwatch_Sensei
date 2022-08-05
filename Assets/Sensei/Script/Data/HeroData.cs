using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Role
{
    Tank,
    Damage,
    Support,
    None
}

public class HeroData
{
    public HERO_ID hero;
    public int health;
    public int shields;
    public int armor;

    public string fullName;
    public string description;
    public Role role = Role.Damage;
    public int stars = 1;

    public string trainingCode = "";

    public AbilityData[] abilities;
    public MatchupData[] matchups;
    public HERO_ID[] strongAgainst;
    public HERO_ID[] weakAgainst;

    public HeroData(HERO_ID hero, int health, int shields, int armor, Role role)
    {
        this.hero = hero;
        this.health = health;
        this.shields = shields;
        this.armor = armor;
        this.role = role;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
