using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacifo : MonoBehaviour
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
            doorAnim.Play("AbrirCacifo", 0, 0.0f);
            doorOpen = true;
            SomPorta.Play();

        }
        else
        {
            doorAnim.Play("FecharCacifo", 0, 0.0f);
            doorOpen = false;
            SomPorta.Play();
        }
    }
}
