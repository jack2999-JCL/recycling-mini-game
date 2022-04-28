using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSliderMusic;
    [SerializeField] Slider volumeSliderEffect;
    
    public float SliderValueMusic;
    public float SliderValueEffect;
    private bool muted = false;
    
    // private void OnEnable()
    // {
    //     volumeSlider.   
    // }
    void Start()
    {
        volumeSliderMusic.value = PlayerPrefs.GetFloat("MusicVolume", SliderValueMusic);
        volumeSliderEffect.value = PlayerPrefs.GetFloat("EffectVolume", SliderValueEffect);
    }
    public void ChangeVolumeMusic()
    {
        AudioListener.volume = volumeSliderMusic.value; 
        volumeSliderMusic.value = PlayerPrefs.GetFloat("MusicVolume", SliderValueMusic);
    }
    public void ChangeSliderMusic(float value)
    {
        SliderValueMusic = value;
        PlayerPrefs.SetFloat("MusicVolume", SliderValueMusic);
    }

    public void ChangeVolumeEffect()
    {
        AudioListener.volume = volumeSliderEffect.value; 
        volumeSliderEffect.value = PlayerPrefs.GetFloat("EffectVolume", SliderValueMusic);
    }
    public void ChangeSliderEffect(float value)
    {
        SliderValueEffect = value;
        PlayerPrefs.SetFloat("EffectVolume", SliderValueEffect);
    }
}
