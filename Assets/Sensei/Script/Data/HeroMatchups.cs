using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMatchups : MonoBehaviour
{
    // Singleton
    public static HeroMatchups Instance { get; private set; }
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

    public TextAsset[] anaMatchups = new TextAsset[(int)HERO_ID.None];

    void Start()
    {

    }


    void Update()
    {

    }
}