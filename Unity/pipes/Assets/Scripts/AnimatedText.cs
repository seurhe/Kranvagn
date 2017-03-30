using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedText : MonoBehaviour {

    public float BaseValue;
    public string Postfix;

    public IEnumerator<float> ValueSequence = new SineDataGenerator();
    private float _passedTime = 0;

	void Start () {
        
	}
	
	void Update () {
        _passedTime += Time.deltaTime;
        if (_passedTime < 0.5)
            return;

        _passedTime -= 0.5f;
        ValueSequence.MoveNext();

        var text = GetComponent<TextMesh>();
        if (text == null)
            return;

        text.text = (ValueSequence.Current + BaseValue).ToString("F1") + Postfix;
    }
}
