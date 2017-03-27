using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	
	void Update () {

        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("Path1"),"oritenttopath", true, "lookahead", 1f, "time", 10));
        }
	}
	
}
