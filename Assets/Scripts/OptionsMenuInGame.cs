using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering;
public class OptionsMenuInGame : MonoBehaviour
{

    private PauseMenu PS;
    public AudioMixer audioMixer;

    Resolution[] resolutions;

    public TMP_Dropdown resolutionDropDown;

    public GameObject optionsmenu;

    public TMP_Dropdown graficos;

    public RenderPipelineAsset[] qualidadeGraficos;

    void Start ()
    {
        graficos.value = QualitySettings.GetQualityLevel();

        resolutions = Screen.resolutions;

        resolutionDropDown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for( int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if(resolutions[i].width == Screen.currentResolution.width && 
            resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResolutionIndex;
        resolutionDropDown.RefreshShownValue();
    }
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void MudaGráficos(int value)
    {

        QualitySettings.SetQualityLevel(value);
        QualitySettings.renderPipeline = qualidadeGraficos[value];

    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution( int resolutionIndex)
    {
        
       Resolution resolution = resolutions[resolutionIndex];
        
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
               optionsmenu.SetActive(false);
               PS.Resume();
        }
    }

}
