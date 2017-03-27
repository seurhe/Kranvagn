using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTest : MonoBehaviour {

	public float GraderUpp;
    public float GraderNer;
    public float Fart;
    public float Dampening;
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

    // Update is called once per frame
    void FixedUpdate () {

        HingeJoint hinge = GetComponent<HingeJoint>();
        JointSpring hingeSpring = hinge.spring;

        // transform.Rotate(Vector3.right * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hingeSpring.spring = Fart;
             hingeSpring.damper = Dampening;
             hingeSpring.targetPosition = GraderUpp;
        }

        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            hingeSpring.spring = Fart;
            hingeSpring.damper = Dampening;
            hingeSpring.targetPosition = GraderNer;

        }

        hinge.spring = hingeSpring;
        hinge.useSpring = true;
    }
}
