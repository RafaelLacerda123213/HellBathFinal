using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MostrarMenuInimigo : MonoBehaviour
{
 
    public GameObject Player;

    public MostrarMenu theMM;


    void Start()
    {
 
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.GetComponent<FirstPersonController>().enabled = false;
            
         
  
           
            theMM.StartCoroutine("AtivarJumpscare");
            
            
            

            theMM.StartCoroutine("DesativarJumpscare");

        }
    }
    


}