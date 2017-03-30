using UnityEngine;
using System.Collections;
using HoloToolkit.Unity;

public class SlowClickOnGaze : MonoBehaviour {

    private readonly float _selectTime = 2;
    private bool _clicking;
    private float _clickTime;

    public GameObject Indicator;

	// Use this for initialization
	void Start () {
	}

    void OnGazeEnter()
    {
        _clicking = true;
        _clickTime = 0;

        var gazeDirection = Camera.main.transform.forward;
        Indicator.transform.position = GazeManager.Instance.Position - gazeDirection.normalized*0.15f;
        Quaternion toQuat = Camera.main.transform.localRotation;
        toQuat.x = 0;
        toQuat.z = 0;
        Indicator.transform.rotation = Camera.main.transform.localRotation;
        Indicator.SetActive(true);
        Indicator.GetComponent<Animation>().Play();
    }

    void OnGazeLeave()
    {
        if (!_clicking)
            return;

        _clicking = false;
        ResetIndicator();
    }

    private void ResetIndicator()
    {
        var animation = Indicator.GetComponent<Animation>();
        animation.Stop();
        animation.Rewind();
        Indicator.SetActive(false);
    }

    void Update()
    {
        if (!_clicking)
            return;

        _clickTime += Time.deltaTime;

        if (_clickTime > _selectTime)
        {
            _clicking = false;
            SendMessage("OnSelect");
            ResetIndicator();
        }
    }
}
