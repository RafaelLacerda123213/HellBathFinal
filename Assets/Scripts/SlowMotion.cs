using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{

    private float slowness = 2f;

    public AudioSource SlowMotionSound;
    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 1f / slowness;
            SlowMotionSound.Play();
        }
        
    }

       void OnTriggerExit (Collider other)
    {
        if(other.tag == "Player")
        {
            Time.timeScale = 1f;
        }
       
    }
}
