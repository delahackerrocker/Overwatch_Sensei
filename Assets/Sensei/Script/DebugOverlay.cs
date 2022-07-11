using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DebugOverlay : MonoBehaviour
{
    public static DebugOverlay Instance { get; private set; }
    public TMP_Text output;

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

    public static void Output(string message)
    {
        //output.text += Evnironment.
        Instance.output.text = message;
    }
}
