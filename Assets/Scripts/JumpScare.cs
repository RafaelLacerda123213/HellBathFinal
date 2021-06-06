using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject maos1;
    public GameObject maos2;
    public GameObject maos3;

    public AudioSource JumpScareSound;
    void Start()
    {
        maos1.SetActive(false);
        maos2.SetActive(false);
        maos3.SetActive(false);
    }


    void OnTriggerEnter (Collider player)
    {
        if(player.tag == "Player")
        {
            JumpScareSound.Play();
            maos1.SetActive(true);
            maos2.SetActive(true);
            maos3.SetActive(true);
            StartCoroutine(DestroyObject());
        }
    }

    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds (4f);
        Destroy(maos1);
        Destroy(maos2);
        Destroy(maos3);
        Destroy(gameObject);
        JumpScareSound.Stop();
    }
}
