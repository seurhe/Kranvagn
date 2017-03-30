using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour {

    private Vector3 _diff;

    public Vector3 MinimumPosition;
    public Vector3 MaximumPosition;

    void Start()
    {
        _diff = MaximumPosition - MinimumPosition;
    }

    public void SetValue(float val)
    {
        transform.localPosition = MinimumPosition + _diff * val;
    }
}
