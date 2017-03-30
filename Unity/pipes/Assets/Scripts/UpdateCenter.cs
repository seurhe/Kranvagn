using UnityEngine;
using System.Collections;

public class UpdateCenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SetCenter();
    }
	
	// Update is called once per frame
	void Update () {
        SetCenter();
	}

    private void SetCenter()
    {
        Shader.SetGlobalVector("_Center", transform.position);

        var width = gameObject.GetComponent<Renderer>().bounds.size.z;
        var visibleDistance = 0.94f * width / 2;
        Shader.SetGlobalFloat("_VisibleDistance", visibleDistance);
    }
}
