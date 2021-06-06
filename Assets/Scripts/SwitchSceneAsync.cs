using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class SwitchSceneAsync : MonoBehaviour
{

    public GameObject loadingScreen;
    public Slider sliderLoding;

    public TMP_Text textProgress;

    private int SceneIndex;
    public GameObject crosshair;

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Player")
        {
           StartCoroutine(LoadAsynchronously(SceneManager.GetActiveScene().buildIndex + 1));
           crosshair.SetActive(false);
        }
    }


    public void LoadLevelAsync(int SceneIndex)
    {
         StartCoroutine(LoadAsynchronously(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadAsynchronously (int SceneIndex)
    {
        loadingScreen.SetActive(true);

        
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        

        while (!operation.isDone){
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            sliderLoding.value = progress;
            textProgress.text = progress * 100f + "%";
            yield return null;
        }
    }
}
