using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsManager : MonoBehaviour
{

     public GameObject parede;

     public GameObject parede2;
     public GameObject parede3;

     private int pontos = 0;
    
    public GameObject textopontos;





    void Awake()
    {
        parede = GameObject.FindWithTag("parede");
        parede2 = GameObject.FindWithTag("parede2");
        parede3 = GameObject.FindWithTag("parede3");

    }
        void Start()
    {
        parede.SetActive(true);
        parede2.SetActive(true);
        parede3.SetActive(true);
        textopontos.SetActive(false);

    }


    public void Pontuacao()
    {
        pontos++;
        textopontos.GetComponent<Text>().text = pontos + "/11";
        if(pontos == 1)
        {
            textopontos.SetActive(true);
        }
        if(pontos == 5)
        {
            parede.SetActive(false);
        } if (pontos == 10)
        {
            parede2.SetActive(false);
        } if (pontos == 11)
        {
            parede3.SetActive(false);
        }
    }


}
