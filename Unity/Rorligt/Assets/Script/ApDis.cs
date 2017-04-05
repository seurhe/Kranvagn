using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApDis : MonoBehaviour {

    public bool isActive = true;

    public void SynOsyn()
    {
        if(isActive)
        {
            this.gameObject.SetActive(false);
            isActive = false;
        }
        else
        {
            this.gameObject.SetActive(true);
            isActive = true;
        }
        
    }

}
