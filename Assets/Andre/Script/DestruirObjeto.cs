using UnityEngine;

public class DestruirObjeto : MonoBehaviour
{





    private GameObject destruir;

    void Start()
    {
        //go = GameObject.Find("goName"); // Find gameobject with name 'goName'.
        destruir = GameObject.FindWithTag("destruir"); // Finds gameobject with tag 'go'.
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            Destroy(destruir); // Destroys gameobject when user presses 'Space' key.
        }
    }





}