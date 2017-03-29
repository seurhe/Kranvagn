using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule
{

    public class UpButton : MonoBehaviour,
                            IInputHandler
    {
        public MotorTest MotorTest;

        Renderer rend;

        void Start()
        {
            rend = GetComponent<Renderer>();
            rend.material.color = Color.blue;
        }

        public void OnInputUp(InputEventData eventData)
        {
            throw new NotImplementedException();
            
        }

        public void OnInputDown(InputEventData eventData)
        {
            rend.material.color = Color.black;
            MotorTest.UpScript();
            throw new NotImplementedException();
        }
    }
}
