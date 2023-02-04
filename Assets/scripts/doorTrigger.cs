using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorTrigger : MonoBehaviour 
{
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("s7y7" ))
        {
            Debug.Log(" sa7yyt ye 9a7ba ");

        }
        else
        {
            Debug.Log("zab ?? ");
        }
      

    }
}
