using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger : MonoBehaviour 
{
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("beb" ))
        {
            Debug.Log(" beeeb sahyt ");
            if(other.gameObject.CompareTag("s7y7"))
            {

            }
            else if (other.gameObject.CompareTag("mouch s7y7"))
            {
                
            }
        }
      

    }

    IEnumerator delai()
    {
        yield return new WaitForSeconds(2);
        SceneManager.GetActiveScene();
    }
}
