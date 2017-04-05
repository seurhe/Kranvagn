using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RedBut : MonoBehaviour, IInputHandler
{

    ApDis ApDis;

    public void OnInputDown(InputEventData eventData)
    {
        ApDis.SynOsyn();
    }

    public void OnInputUp(InputEventData eventData)
    {
        throw new NotImplementedException();
    }
}
