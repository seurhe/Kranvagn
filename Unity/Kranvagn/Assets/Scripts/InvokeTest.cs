using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTest : MonoBehaviour {

    public int tid = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("Hejscript", tid);
        }
    }
           
    void Hejscript()
    {
        Debug.Log( tid + " sekunder har gått sedan knapptryck");
    }
}
