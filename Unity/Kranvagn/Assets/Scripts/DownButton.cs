using UnityEngine;

namespace HoloToolkit.Unity.InputModule
{

    public class DownButton : MonoBehaviour,
                            IInputHandler
    {
        public MotorTest MotorTest;
        public Motor2 Motor2;

        public void OnInputUp(InputEventData eventData)
        {

        }

        public void OnInputDown(InputEventData eventData)
        {
            MotorTest.InvokeRor();
            Motor2.InvokeRor();
        }
    }
}
