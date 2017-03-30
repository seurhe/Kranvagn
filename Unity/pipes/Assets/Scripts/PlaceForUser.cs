using UnityEngine;
using System.Collections;

public class PlaceForUser : MonoBehaviour {

	public void Place()
    {
        
        var cameraTransform = Camera.main.transform;
        var viewCenter = cameraTransform.position + cameraTransform.forward.normalized * 1.5f;

        // Place next to view center
        transform.position = viewCenter;

        // Rotate this object to face the user
        Quaternion toQuat = cameraTransform.localRotation;
        toQuat.x = 0;
        toQuat.z = 0;
        transform.rotation = toQuat;

        gameObject.SetActive(true);
    }
}
