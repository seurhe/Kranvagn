using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTest : MonoBehaviour {

    public MotorTest MotorTest;

    public Motor2 Motor2;

    bool NeverDone;

    void Start()
    {
        NeverDone = true;
    }

    void Update()
    {
        if (NeverDone)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MotorTest.InvokeMotorTest();
                Motor2.InvokeMotor2();
                NeverDone = false;
            }
        }
    }

}
