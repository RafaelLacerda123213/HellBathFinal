using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{

    public AudioSource madeiraSound;

    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
            madeiraSound.Play();
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
