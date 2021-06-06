using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class SkipButton : MonoBehaviour
{
    public GameObject button;

    private float timerskip = 4f;

    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timerskip -= Time.deltaTime;
        if(timerskip <= 0f)
        {
            button.SetActive(true);
        }
    }

    public void Skip()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
