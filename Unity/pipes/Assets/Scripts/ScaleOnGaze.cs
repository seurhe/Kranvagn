using UnityEngine;

public class ScaleOnGaze : MonoBehaviour {

    public GameObject ObjectToScale;

    public bool ScaleUp = true;

    void Start()
    {
        GetComponent<Renderer>().enabled = false;
    }

    void OnGazeEnter()
    {
        GetComponent<Renderer>().enabled = true;
        ObjectToScale.SendMessage("StartScaling", ScaleUp);
    }

    void OnGazeLeave()
    {
        GetComponent<Renderer>().enabled = false;
        ObjectToScale.SendMessage("StopScaling");
    }
}
