using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agrachar : MonoBehaviour
{
    public CharacterController playerCol;
    float originalHeight;
    public float reduceHeight;



    void Start()
    {
        playerCol = GetComponent<CharacterController>();
        originalHeight = playerCol.height;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
            crouch();
        else if(Input.GetKeyUp(KeyCode.LeftControl))
            normal();

        
    }

    void crouch()
    {
        playerCol.height = reduceHeight;

    }

        void normal()
    {
        playerCol.height = originalHeight;

    }
}
