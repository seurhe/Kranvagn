using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour {
    public MotorTest MotorTest;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }

    void onSelect()
    {
        rend.material.color = Color.black;
        MotorTest.UpScript();
    } 
}
