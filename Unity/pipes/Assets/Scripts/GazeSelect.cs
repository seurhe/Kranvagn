using UnityEngine;
using System.Collections;

public class GazeSelect : MonoBehaviour
{
    private Material _originalMaterial;

    public Material OnGazeMaterial;

    public void OnGazeEnter()
    {
        if (OnGazeMaterial == null)
            return;

        var renderer = gameObject.GetComponent<Renderer>();
        _originalMaterial = renderer.material;
        renderer.material = OnGazeMaterial;
    }

    public void OnGazeLeave()
    {
        if (_originalMaterial == null)
            return;

        gameObject.GetComponent<Renderer>().material = _originalMaterial;
    }
}
