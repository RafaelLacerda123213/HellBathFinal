using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruções : MonoBehaviour
{

    [SerializeField] private GameObject instrucaoUI;

    
    
        void OnTriggerEnter(Collider other)
    {
       
        
        
            instrucaoUI.SetActive(true);
        
        
    }
    


        void OnTriggerExit (Collider other)
        {
            
            
                instrucaoUI.SetActive(false);
            
           
            
        }
}
