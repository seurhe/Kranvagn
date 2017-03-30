using UnityEngine;

public class TimeScale : MonoBehaviour {

    private bool _isScaling;
    private bool _up;
    private Vector3 _initialScale;
    private Vector3 _minScale;
    private Vector3 _maxScale;

    public float MaxValue;
    public float MinValue;
    public float Speed = 1;
    public GameObject Slider;

    void Start()
    {
        _initialScale = transform.localScale;
        _minScale = _initialScale + Vector3.one * MinValue;
        _maxScale = _initialScale + Vector3.one * MaxValue;

        UpdateSlider(_initialScale);
    }

    public void Reset()
    {
        transform.localScale = _initialScale;
        UpdateSlider(_initialScale);
    }

	// Use this for initialization
	public void StartScaling (bool up) {
        _up = up;
        _isScaling = true;
	}

    public void StopScaling ()
    {
        _isScaling = false;
    }
	
	void Update () {
        if (!_isScaling)
            return;

        var diff = (_up ? Speed : -Speed) * Time.deltaTime;
        var newScale = transform.localScale + Vector3.one * diff;

        if (_up && newScale.magnitude > _maxScale.magnitude)
        {
            _isScaling = false;
            newScale = _maxScale;
        }
        else if (!_up && newScale.magnitude < _minScale.magnitude)
        {
            _isScaling = false;
            newScale = _minScale;
        }

        transform.localScale = newScale;

        UpdateSlider(newScale);
    }

    private void UpdateSlider(Vector3 position)
    {
        if (Slider != null)
        {
            Slider.SendMessage("SetValue", (position - _minScale).magnitude / (_maxScale - _minScale).magnitude);
        }
    }
}
