using UnityEngine;
using System.Collections;

public class Organizer : MonoBehaviour
{
    public static Organizer Instance;

	// Use this for initialization
	void Start ()
	{
	    Instance = this;
	}

    public void PostMove(Vector3 startPos, Vector3 endPos)
    {
        //Menu.transform.position = Menu.transform.position + (endPos - startPos);
    }
}
