using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(AudioSource))]
public class Teleporte : MonoBehaviour
{

    public Transform[] destinos;
    public AudioClip audioTeleporte;
    [Space(10)]
    public bool destruirAoColidir = false;
    AudioSource emissorDeSom;
    bool rotinaIniciada = false;

    void Awake()
    {
        emissorDeSom = GetComponent<AudioSource>();
        emissorDeSom.playOnAwake = false;
        emissorDeSom.loop = false;
        GetComponent<BoxCollider>().isTrigger = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (destinos.Length > 0 && !rotinaIniciada)
        {
            int destino = Random.Range(0, destinos.Length);
            if (destinos[destino])
            {
                FirstPersonController controlador = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
                controlador.enabled = false;
                
                other.transform.position = destinos[destino].position;
                other.transform.rotation = destinos[destino].rotation;
                if (destruirAoColidir)
                {
                    StartCoroutine("EsperarParaDestruir");
                }
            }
            if (audioTeleporte)
            {
                emissorDeSom.clip = audioTeleporte;
                emissorDeSom.PlayOneShot(emissorDeSom.clip);
            }
        }
    }

    IEnumerator EsperarParaDestruir()
    {
        FirstPersonController controlador = GameObject.Find("FPSController").GetComponent<FirstPersonController>();
        rotinaIniciada = true;
        MeshRenderer mesh = GetComponent<MeshRenderer>();
        if (mesh)
        {
            mesh.enabled = false;
        }
        //UTILIZAR ESTE CODIGO PARA TOCAR O SOM, APOS 5 SEGUNDOS APARECE O MENU DE RESPAWN (JUMPSCARE) | COLOCAR CODIGO DO MENU AQUI
        yield return new WaitForSeconds(1);
        controlador.enabled = true;
        Destroy(gameObject);
    }
}


