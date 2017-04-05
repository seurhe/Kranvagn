using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SynOsyn : MonoBehaviour, IInputHandler {

    public Renderer rend;
    public bool isActive = true;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    public void OnInputDown(InputEventData eventData)
    {
        if (isActive)
        {
            rend.enabled = false;
            isActive = false;
        }
        else
        {
            rend.enabled = true;
            isActive = true;
        }

    }

    public void OnInputUp(InputEventData eventData)
    {
        throw new NotImplementedException();
    }
}
