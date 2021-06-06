using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeout : MonoBehaviour
{
    public Image fadeOut;

    

   

    // Start is called before the first frame update
    void Start()
    {
        fadeOut.canvasRenderer.SetAlpha(1.0f);

        Fade();

      
    }

    // Update is called once per frame
    void Fade()
    {
        fadeOut.CrossFadeAlpha(0, 4, false);
    }
    
 


}
