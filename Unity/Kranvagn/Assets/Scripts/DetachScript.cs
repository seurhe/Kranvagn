﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachScript : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Translate(0, -0.15f, 0, Space.World);
            transform.Rotate(60, 0, 0, Space.World);
            transform.parent = null;
        }
	}
}
