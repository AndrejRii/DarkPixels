using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class SetVolume : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    void Awake()
    {
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

}
