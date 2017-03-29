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
        public Motor2 Motor2;

        public void OnInputUp(InputEventData eventData)
        {
            throw new NotImplementedException();
            
        }

        public void OnInputDown(InputEventData eventData)
        {
            MotorTest.InvokeStart();
            Motor2.InvokeStart();
            throw new NotImplementedException();
        }
    }
}
