using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {


   


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Flytta()
    {
        Vector3 pos = GameObject.Find("Cuben").transform.position;
        Quaternion rot = GameObject.Find("Cuben").transform.rotation;
        transform.position = pos;
        transform.rotation = rot;
    }

}
