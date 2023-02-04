using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorTrigger : MonoBehaviour 
{
    public bool canpress =false; 
    public bool canpress1 = false;
    public bool collided=false;
    public GameObject door;
    public GameObject door1;

    private void Update()
    {


        if (Input.GetKeyDown(KeyCode.E) && canpress && collided)
        {

            door.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.E) && canpress1 && collided)
        {

            door1.SetActive(false);

        }





        if (Input.GetKeyDown(KeyCode.E) && collided && !canpress && !canpress1)
        {
            
           
            StartCoroutine(delai());
        }
    }
    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("s7y7"))
        {
            collided = true;
            canpress = true;

        }
        if (other.gameObject.CompareTag("s7y71"))
        {
            collided = true;
            canpress1 = true;

        }
        if (other.gameObject.CompareTag("mouch s7y7"))
            {

            collided=true;
           

        }
      

    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("s7y7"))
        {
            canpress = false;
           
        }
        if (other.gameObject.CompareTag("s7y71"))
        {
            canpress1 = false;

        }
    }
    IEnumerator delai()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}
