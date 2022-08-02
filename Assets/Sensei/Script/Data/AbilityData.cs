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

public class AbilityData : MonoBehaviour
{
    public bool isUltimate = false;

    public string abilityName = "";
    public string abilityDetail = "";

    public ControllerButton controllerButton = ControllerButton.Passive;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
