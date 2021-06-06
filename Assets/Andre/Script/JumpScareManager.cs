using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class JumpScareManager : MonoBehaviour
{
    public GameObject respawn;
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Inimigo;
    [SerializeField] private Transform respawnPoint;
    [SerializeField] private Transform respawnPointinimigo;
    public GameObject inimigoaparecer;

    public GameObject Jack;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Respawn()
    {
        Player.transform.position = respawnPoint.transform.position;
        Inimigo.transform.position = respawnPointinimigo.transform.position;
        // respawn.SetActive(false);
        Cursor.visible = false;
        Player.GetComponent<FirstPersonController>().enabled = true;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        inimigoaparecer.SetActive(true);
        Jack.SetActive(true);
        respawn.SetActive(false);

    }

}
