using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destruir : MonoBehaviour
{
    public GameObject txtAviso;

    public GameObject versaoDestruida;

    private bool aciona = false;

    public AudioSource somPartir;

    void Start()
    {
        txtAviso.SetActive(false);
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
        aciona = true;
        txtAviso.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            aciona = false;
            txtAviso.SetActive(false);
        }
        
        
    }

        void Update()
    {
        if (aciona) { 
            if (Input.GetKey(KeyCode.Mouse0))
        {
            Destruicao();
        }
        }
    }

    void Destruicao()
    {
        Instantiate(versaoDestruida, transform.position, transform.rotation);
        Destroy(gameObject);
        txtAviso.SetActive(false);
        somPartir.Play();
    }
}
