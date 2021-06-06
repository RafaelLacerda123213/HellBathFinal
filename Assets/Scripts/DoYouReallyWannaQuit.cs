using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoYouReallyWannaQuit : MonoBehaviour
{
    private PauseMenu PS;

    public GameObject reallyquit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

 void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
               reallyquit.SetActive(false);
               PS.Resume();
        }
    }
}
