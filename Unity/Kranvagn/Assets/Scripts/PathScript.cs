using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathScript : MonoBehaviour {

    GameObject pathGO;

    Transform targetPathNode;
    int pathNodeIndex = 0;

    public float speed = 5f;

	// Use this for initialization
	void Start () {
        pathGO = GameObject.Find("Path");
	}
	
    void GetNextPathNode()
    {
        if(pathNodeIndex < pathGO.transform.childCount)
        {
            targetPathNode = pathGO.transform.GetChild(pathNodeIndex);
            pathNodeIndex++;
        }

        else
        {
            targetPathNode = null;
            //ReachedGoal();
        }
    }

	// Update is called once per frame
	void Update () {
		if(targetPathNode == null)
        {
            GetNextPathNode();
            if(targetPathNode == null)
            {
                //ReachedGoal();
                return;
            }
        }

        Vector3 dir = targetPathNode.position - this.transform.localPosition;

        float distThisFrame = speed * Time.deltaTime;

        if(dir.magnitude <= distThisFrame)
        {
            targetPathNode = null;
        }
        else
        {
            transform.Translate(dir.normalized * distThisFrame, Space.World);
            Quaternion targetRotation = Quaternion.LookRotation(dir);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, targetRotation, Time.deltaTime * 5);
        }
	}
}
