using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiden : MonoBehaviour
{

    public int tid;

    public MotorTest MotorTest;

    public Motor2 Motor2;

    int[] tiden = new int[4];

    public int tid1;

    public int tid2;

    public int tid3;

    public int tid4;

    void Start()
    {
        tiden[0] = tid1;
        tiden[1] = tid2;
        tiden[2] = tid3;
        tiden[3] = tid4;

        for (int i = 0; i < tiden.Length; i++)
        {
            Debug.Log("Tid nummer " + i + " = " + tiden[i]);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        

        if (Time.time - tid == tid)
        {
            Debug.Log((tid + tid) + " sekunder har gått");

        }

        if (Time.time - (tid * 2) == tid)
        {
            Debug.Log((tid * 2 + tid) + " sekunder har gått");

            MotorTest.UpScript();

        }

        if (Time.time - (tid * 2 + 2) == tid)
        {
            Debug.Log((tid * 2 + 2 + tid) + " sekunder har gått");

            Motor2.RuntScript();

        }

        if (Time.time - (tid * 10) == tid)
        {
            MotorTest.DownScript();

            Debug.Log((tid * 10 + tid) + " sekunder har gått");
        }

        if (Time.time - (tid * 10 + 2) == tid)
        {
            Motor2.RuntScriptet();

            Debug.Log((tid * 10 + 2 + tid) + " sekunder har gått");
        }

        if (Time.time - (tid * 10 + 10) == tid)
        {
            MotorTest.UpScript();

            Debug.Log((tid * 10 + 10 + tid) + " sekunder har gått");
        }


    }
}