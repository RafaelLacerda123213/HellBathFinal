using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiarioTrigger : MonoBehaviour
{
    public PauseMenu thePM;
    public GameObject avisoTXT;
    private void OnTriggerEnter(Collider other)
    {
       
        thePM.acionarDiario = true;
        avisoTXT.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        thePM.acionarDiario = false;
        avisoTXT.SetActive(false);
    }

    void Start()
    {
        avisoTXT.SetActive(false);
    }

}
