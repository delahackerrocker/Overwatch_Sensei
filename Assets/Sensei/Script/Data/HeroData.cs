using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroData : MonoBehaviour
{
    public HERO_ID hero;
    public int health;
    public int shields;
    public int armor;

    public string fullName;
    public AbilityData[] abilities;
    public MatchupData[] matchups;

    public HeroData(HERO_ID hero, int health, int shields, int armor)
    {
        this.hero = hero;
        this.health = health;
        this.shields = shields;
        this.armor = armor;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
