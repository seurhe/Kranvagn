using UnityEngine;
using System.Collections;

public class Sink : MonoBehaviour {

    private float _scale;
    private float _pos;
    private bool _isInBottom;
    private Material _material;

    public Material InvisibleMaterial;

    private Vector3 _upPos;
    private Vector3 _downPos;
    private bool _changing;
    private bool _up = true;

    public string GroupId;

    public bool SetInactive = true;

    public float Offset;

    // Use this for initialization
    void Start()
    {
        _scale = transform.localScale.y;
        _pos = transform.localPosition.y;
        SetPositions();
    }

    public void SetPositions()
    {
        if (_up)
        {
            _upPos = gameObject.transform.position;
            _downPos = _upPos - new Vector3(0, 1, 0) * (gameObject.GetComponent<Renderer>().bounds.size.y + Offset);
        }
        else
        {
            _downPos = gameObject.transform.position;
            _upPos = _downPos + new Vector3(0,1,0) * (gameObject.GetComponent<Renderer>().bounds.size.y - Offset);
        }
    }

    public void ToggleSink(string groupId)
    {
        if (!string.IsNullOrEmpty(groupId) && groupId != GroupId)
            return;

        _up = !_up;
        _changing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_changing)
            return;

        var animationTime = 0.5f;
        var movePart = Time.deltaTime / animationTime;
        var rescale = (_up ? _scale : -_scale) * movePart;
        var newScale = transform.localScale.y + rescale;

        if (_isInBottom)
        {
            GetComponent<Renderer>().enabled = true;
            _isInBottom = false;
        }

        if (_up && newScale > _scale)
        {
            _changing = false;
            newScale = _scale;
        }
        else if (!_up && newScale < 0)
        {
            _changing = false;
            newScale = 0;
            GetComponent<Renderer>().enabled = false;
            _isInBottom = true;
        }

        transform.localScale = new Vector3(transform.localScale.x, newScale, transform.localScale.z);
    }
}
