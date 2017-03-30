using UnityEngine;
using System.Collections;

public class ShowInfo : MonoBehaviour {
    

	public void Open()
    {
        Quaternion toQuat = Camera.main.transform.localRotation;
        toQuat.x = 0;
        toQuat.z = 0;
        transform.rotation = toQuat;
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
