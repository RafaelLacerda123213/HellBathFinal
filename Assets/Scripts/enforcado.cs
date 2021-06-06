using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enforcado : MonoBehaviour
{

    public GameObject bicho;

    public AudioSource SomBicho;

    public GameObject paredeTrigger;

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            bicho.SetActive(false);
            SomBicho.Play();
            paredeTrigger.SetActive(false);
        }
        
    }

       void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            Object.Destroy(gameObject);
        }
       
    }


        

}
