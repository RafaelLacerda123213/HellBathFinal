using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaInimigo : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {

        if (GetComponent<Collider>().GetType() == typeof(SphereCollider)) print("Box");
        {
            Debug.Log("Esfera entrar");
            audioSource.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (GetComponent<Collider>().GetType() == typeof(SphereCollider)) print("Box");
        {
            Debug.Log("Esfera sair");
        }
    }

}
