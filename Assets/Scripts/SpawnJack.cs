using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnJack : MonoBehaviour
{
    public AudioSource jackspawn;
    public GameObject Jack;
    public GameObject JackAviso;

    public GameObject trigger;


    
    void Start()
    {
        Jack.SetActive(false);
        JackAviso.SetActive(false);
    }


    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            jackspawn.Play();
            JackAviso.SetActive(true);
            Jack.SetActive(true);
        }
        
    }

       void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            JackAviso.SetActive(false);
            Object.Destroy(gameObject);
        }
       
    }
}
