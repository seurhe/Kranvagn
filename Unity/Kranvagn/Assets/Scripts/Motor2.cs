using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor2 : MonoBehaviour
{



    public float SpeedOne;
    public float SpeedTwo;
    public float LimitTop;
    public float LimitBot;

    void Start()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointLimits limits = hinge.limits;
        limits.min = LimitBot;
        limits.bounciness = 0;
        limits.bounceMinVelocity = 0;
        limits.max = LimitTop;
        hinge.limits = limits;
        hinge.useLimits = true;
    }

    void FixedUpdate()
    {

       /* HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;

        if (Input.GetKeyDown(KeyCode.P))
        {
            motor.force = 100;
            motor.targetVelocity = SpeedOne;
        }

        else if (Input.GetKeyDown(KeyCode.O))
        {
            motor.force = 100;
            motor.targetVelocity = SpeedTwo;

        }


        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;*/

    }

    public void RuntScript()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;

        motor.force = 100;
        motor.targetVelocity = SpeedOne;

        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;
    }

    public void RuntScriptet()
    {
        HingeJoint hinge = GetComponent<HingeJoint>();
        JointMotor motor = hinge.motor;

        motor.force = 100;
        motor.targetVelocity = SpeedTwo;

        motor.freeSpin = false;
        hinge.motor = motor;
        hinge.useMotor = true;
    }
}
