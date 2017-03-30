using UnityEngine;
using System.Collections;

public class VisibilityToggle : MonoBehaviour {

    private bool _visible = true;

	public void ToggleVisibility()
    {
        _visible = !_visible;
        gameObject.SetActive(_visible);
    }
}
