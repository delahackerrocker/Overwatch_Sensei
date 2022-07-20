using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public static Main Instance { get; private set; }

    public Heroes selectedHero = Heroes.None;
    public Heroes counterPick = Heroes.None;

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

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
