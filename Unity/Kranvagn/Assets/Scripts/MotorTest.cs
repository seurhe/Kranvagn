using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorTest : MonoBehaviour {

    public int tid1;
    public int tid2;
    public int tid3;

    public float SpeedUp;
    public float SpeedDown;
    public float LimitUp;
    public float LimitDown;

    void Start()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointLimits limits = hinge.limits;
        limits.min = LimitDown;
        limits.bounciness = 0;
        limits.bounceMinVelocity = 0;
        limits.max = LimitUp;
        hinge.limits = limits;
        hinge.useLimits = true;
    }

    void FixedUpdate () {

       /* HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            motor.force = 100;
            motor.targetVelocity = SpeedUp;
           }

        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            motor.force = 100;
            motor.targetVelocity = SpeedDown;

        }

        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;*/

    }

    public void InvokeMotorTest()
    {
        Invoke("UpScript", tid1);
        Invoke("DownScript", tid2);
        Invoke("UpScript", tid3);
    }

    public void UpScript ()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;

        motor.force = 100;
        motor.targetVelocity = SpeedUp;
        hinge.motor = motor;
        hinge.useMotor = true;
    }

    public void DownScript()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;

        motor.force = 100;
        motor.targetVelocity = SpeedDown;
        hinge.motor = motor;
        hinge.useMotor = true;
    }
}

