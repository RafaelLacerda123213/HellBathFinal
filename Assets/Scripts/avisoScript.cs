using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class avisoScript : MonoBehaviour
{

    public GameObject avisoTXT;
    public GameObject triggeroof;

private void OnTriggerEnter(Collider other)
    {
       if(other.tag == "Player"){
           avisoTXT.SetActive(true);
       }
        
    }
    private void OnTriggerExit(Collider other)
    {
       if(other.tag == "Player"){
                   avisoTXT.SetActive(false);
                    triggeroof.SetActive(false);
       }


    }

}
