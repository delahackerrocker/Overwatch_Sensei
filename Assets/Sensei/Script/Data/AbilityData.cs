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
    None
}

public class AbilityData : MonoBehaviour
{
    public string abilityName;
    public string abilityDetail;
    public ControllerButton controllerButton;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
