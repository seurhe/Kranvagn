using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Holotoolkit.Unity.InputModule
{

    public class CubenScript : MonoBehaviour , IInputHandler
    {

        public CubeScript CubeScript;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnInputDown(InputEventData eventData)
        {
            CubeScript.Flytta();
            Debug.Log("Cuben Pressed");
            gameObject.active = false;
        }

        public void OnInputUp(InputEventData eventData)
        {
            throw new NotImplementedException();
        }
    }
}
