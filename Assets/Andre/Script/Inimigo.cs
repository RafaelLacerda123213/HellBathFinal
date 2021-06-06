using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Inimigo : MonoBehaviour
{
public NavMeshAgent inimigo;
    public Transform Player;
    public float distanciaMinima = 8f;



    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
        inimigo.stoppingDistance = distanciaMinima;
    }
    void Update()
    {
        inimigo.SetDestination(Player.position);

    }

    

}
