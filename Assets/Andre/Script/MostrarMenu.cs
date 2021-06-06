using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class MostrarMenu : MonoBehaviour
{
 
    public GameObject Player;
    public GameObject respawn;
    public AudioSource jumpscaresound;

    public GameObject inimigoPARTEJUMPSCARE;
    public GameObject FlashImg;
    public GameObject camaraplayer;

    public AudioSource musicaLoopStop;

    public GameObject Jack;


    void Start()
    {
 
    }
    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     {
    //         Player.GetComponent<FirstPersonController>().enabled = false;
         
  
           
    //         StartCoroutine("AtivarJumpscare");
            
            
            

    //         StartCoroutine("DesativarJumpscare");

    //     }
    // }
     public IEnumerator AtivarJumpscare()
    {

        yield return new WaitForSeconds(0.3f);
        JumpScare();



    }

        public IEnumerator DesativarJumpscare()
    {

        yield return new WaitForSeconds(2f);
        endJumpScare();
        respawn.SetActive(true);


    }

    public void JumpScare()
    {
        
        jumpscaresound.Play();
        inimigoPARTEJUMPSCARE.SetActive(true);
        camaraplayer.SetActive(false);
        FlashImg.SetActive(true);
        musicaLoopStop.Stop();
        Jack.SetActive(false);
        

    }

    public void endJumpScare()
    {
        
        jumpscaresound.Stop();
        inimigoPARTEJUMPSCARE.SetActive(false);
        camaraplayer.SetActive(true);
        FlashImg.SetActive(false);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        
    }


}