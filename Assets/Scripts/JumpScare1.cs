using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare1 : MonoBehaviour
{
    public GameObject bicho;

    public AudioSource JumpScareSound;
    void Start()
    {
        bicho.SetActive(false);

    }


    void OnTriggerEnter (Collider player)
    {
        if(player.tag == "Player")
        {
            JumpScareSound.Play();
            bicho.SetActive(true);
            StartCoroutine(DestroyObject());
        }
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds (3f);
        Destroy(bicho);
        Destroy(gameObject);
        JumpScareSound.Stop();
    }
}
