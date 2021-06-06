using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{
    private Animator doorAnim;

    private bool doorOpen = false;

    public AudioSource SomPorta;

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        if(!doorOpen)
        {
            doorAnim.Play("AbrirPorta", 0, 0.0f);
            doorOpen = true;
            SomPorta.Play();

        }
        else
        {
            doorAnim.Play("FecharPorta", 0, 0.0f);
            doorOpen = false;
            SomPorta.Play();
        }
    }
}
