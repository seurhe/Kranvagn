using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour {

    public GameObject IndicatorPrefab;

    public Vector3 startPos;
    public Vector3 endPos;

    private GameObject _indicator;
    private Vector3 _step;
    private float _travelDistance;

	// Use this for initialization
	void Start () {
        _step = (endPos - startPos)/0.5f;
        _travelDistance = (endPos - startPos).magnitude;

        _indicator = Instantiate(IndicatorPrefab);
        _indicator.transform.parent = transform;
        _indicator.transform.localPosition = startPos;
	}
	
	// Update is called once per frame
	void Update () {
        _indicator.transform.localPosition += _step * Time.deltaTime;

        if ((_indicator.transform.localPosition - startPos).magnitude > _travelDistance)
        {
            _indicator.transform.localPosition = startPos;
        }
	}
}
