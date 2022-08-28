using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroSummaries : MonoBehaviour
{
    // Singleton
    public static HeroSummaries Instance { get; private set; }
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

    public TextAsset[] textAssets = new TextAsset[(int)HERO_ID.None];

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}