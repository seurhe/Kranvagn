using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton : MonoBehaviour {

    public MotorTest MotorTest;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.gray;
    }

    void onSelect()
    {
        rend.material.color = Color.red;
        MotorTest.DownScript();
    }
}
