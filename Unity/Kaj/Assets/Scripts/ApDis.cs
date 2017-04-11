using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApDis : MonoBehaviour {

    public bool Aktiv = true;



    public void ApDiss()
    {
        if (Aktiv)
        {
            gameObject.SetActive(false);
        }

        else
        {
            gameObject.SetActive(true);
            Aktiv = false;
        }
    }
}
