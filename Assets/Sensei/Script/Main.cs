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

    public Heroes selectedHero = Heroes.None;
    public Heroes counterPick = Heroes.None;

    void Update()
    {
        
    }
}
