using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    
    public float SliderValue;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", SliderValue);
    }
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value; 
        volumeSlider.value = PlayerPrefs.GetFloat("MusicVolume", SliderValue);
    }
    public void ChangeSlider(float value)
    {
        SliderValue = value;
        PlayerPrefs.SetFloat("MusicVolume", SliderValue);
    }

}
