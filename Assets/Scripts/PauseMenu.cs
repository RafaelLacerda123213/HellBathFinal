using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
   
    public GameObject pauseMenuUI;

    public GameObject DiarioUI;

    public GameObject thePlayer;

    public AudioSource colectavelSound;

    // private MouseLook ML;

    public GameObject txtAviso;

    public bool acionarDiario = false;

    public GameObject diario;

    public GameObject crosshair;
    
    private float timer = 2f;


    void Start()
    {
        pauseMenuUI.SetActive(false);
        DiarioUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }

        if (acionarDiario) { 
            if (Input.GetKey(KeyCode.F))
        {
            LerDiario();
            colectavelSound.Play();
            
        }
        }

        
    }

    public void Resume()
        {
            thePlayer.GetComponent<FirstPersonController>().enabled = true;
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            Cursor.visible = false;
            // ML.m_cursorIsLocked = true;
            Cursor.lockState = CursorLockMode.Locked;
            crosshair.SetActive(true);

        }

        public void Pause()
        {
            thePlayer.GetComponent<FirstPersonController>().enabled = false;
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
            Cursor.visible = true;
            // ML.m_cursorIsLocked = false;
            Cursor.lockState = CursorLockMode.None;
            crosshair.SetActive(false);
        
        
        }

        public void LerDiario()
        {
            thePlayer.GetComponent<FirstPersonController>().enabled = false;
            DiarioUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
            Cursor.visible = true;
            // ML.m_cursorIsLocked = false;
            Cursor.lockState = CursorLockMode.None;
            txtAviso.SetActive(false);
            crosshair.SetActive(false);
        
        
        }

        public void FecharDiario()
        {
            thePlayer.GetComponent<FirstPersonController>().enabled = true;
            DiarioUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            Cursor.visible = false;
            // ML.m_cursorIsLocked = true;
            Cursor.lockState = CursorLockMode.Locked;
            GameObject.Find("cenario").GetComponent<GameManager>().Pontuacao();
            diario.SetActive(false);
            crosshair.SetActive(true);


        }


    public void QuitGame()
    {
        Debug.Log("quit!");
        Application.Quit();
    }

    // public void BackMenu()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    // }


}
