using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodar : MonoBehaviour
{
[SerializeField] float duracao = 6f;

    void Start()
    {
        Destroy(gameObject,duracao);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45,30,15) * Time.deltaTime);
    }

}
