using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class FireSink : MonoBehaviour
{
    private Material _initialMaterial;
    private bool _selected = true;

    public Material DeselectedMaterial;
    public GameObject Container;
    public string GroupId;

    void Start()
    {
        var renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            _initialMaterial = renderer.material;
        }
    }

    void OnSelect()
    {
        if (this.enabled == false) return;
        if (Container != null)
        {
            Container.BroadcastMessage("ToggleSink", GroupId);
        }
        /*
        _selected = !_selected;
        gameObject.GetComponent<Renderer>().material = _selected ? _initialMaterial : DeselectedMaterial;
        */
    }

    public void Fire(string groupId)
    {
        Container.BroadcastMessage("ToggleSink", groupId);
    }
}
