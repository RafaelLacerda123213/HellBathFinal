using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerSwitchPlayer : MonoBehaviour
{

public GameObject thePlayerCam;

public GameObject thePlayerCam2;
    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            thePlayerCam.SetActive(false);
            thePlayerCam2.SetActive(true);
        }
        
    }

       void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            thePlayerCam.SetActive(true);
            thePlayerCam2.SetActive(false);  
        }
       
    }
}
