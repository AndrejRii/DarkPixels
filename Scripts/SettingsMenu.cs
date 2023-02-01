using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System.Linq;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private TMP_Dropdown resolutionDropdown;
    [SerializeField] private TMP_Dropdown graphicDropdown;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private Toggle fullscreenToggle;

    private Resolution[] resolutions;
    //public static int resolutionIndex2 = -1;
    //public static int graphicIndex = 2;
    //public static bool fullscreenValue = true;
    //public static float volumeValue = -40f;

    private void Start()
    {
        //volumeSlider.value = volumeValue;
        //fullscreenToggle.isOn = fullscreenValue;
        //graphicDropdown.value = graphicIndex;

        //audioMixer.SetFloat("Volume", volumeValue);

        resolutions = Screen.resolutions; //.Select(resolution => new Resolution { width = resolution.width, height = resolution.height }).Distinct().ToArray();        

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)   //.currentResolution .currentResolution
            {
                currentResolutionIndex = i;                
            }

        }

        //if (resolutionIndex2 == -1)
        //{
        //    resolutionIndex2 = currentResolutionIndex;
        //} else
        //{
        //    resolutionIndex2 = resolutionIndex2;
        //}
                
        resolutionDropdown.AddOptions(options);   
        resolutionDropdown.value = currentResolutionIndex;  //resolutionIndex2
        resolutionDropdown.RefreshShownValue();

        int currentQualityIndex = QualitySettings.GetQualityLevel();
        graphicDropdown.value = currentQualityIndex;
        graphicDropdown.RefreshShownValue();

        fullscreenToggle.isOn = Screen.fullScreen;

        try
        {
            float vol = PlayerPrefs.GetFloat("Volume");
            volumeSlider.value = vol;
        } 
        catch
        {
            volumeSlider.value = 0;
        }
    }   

    public void SetResolution(int resolutionIndex) 
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        //resolutionIndex2 = resolutionIndex; 
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        //volumeValue = volumeSlider.value;
        PlayerPrefs.SetFloat("Volume", volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);  //, true
        //graphicIndex = qualityIndex;
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        //fullscreenValue = fullscreenToggle.isOn;
    }

}

