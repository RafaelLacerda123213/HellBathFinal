using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Cartas : MonoBehaviour
{
        public GameObject noteImage;

        public GameObject cartaObjeto;


        public AudioSource collectSound;

        public GameObject crosshair;
        


        void Start()
        {
            noteImage.SetActive(false);
        }
       

        void OnTriggerEnter (Collider other)
        {
            if (other.CompareTag("Player")) 
            {
                noteImage.SetActive(true);
                collectSound.Play();
                Debug.Log("cenario =" + GameObject.Find("cenario"));
                GameObject.Find("cenario").GetComponent<GameManager>().Pontuacao();
                other.transform.parent.gameObject.SetActive(false);
                crosshair.SetActive(false);

            }  
            
        }
        

        void OnTriggerExit(Collider other)
        {

            if (other.CompareTag("Player")) 
            {
                noteImage.SetActive(false);
                cartaObjeto.SetActive(false);
                crosshair.SetActive(true);
                
            }

        }

}
