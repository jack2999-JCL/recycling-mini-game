// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class MusicController : MonoBehaviour
// {
//     [SerializeField] private Slider volumeSlider = null;
//     [SerializeField] private Text volumeTextUI = null;
    
//     void Start()
//     {
//         LoadValus();
        
//     }
//     public void VolumeSlider(float volume)
//     {
//         volumeTextUI.text = volume.ToString("0.0");
//     }

//     public void SaveVolumeButton()
//     {
//         float volumeValus = volumeSlider.value;
//         PlayerPrefs.SetFloat("volumevalus", volumeValus);
//         LoadValus();
//     }
//     void LoadValus()
//     {
//         float volumeValus = PlayerPrefs.GetFloat("VolumeValue");
//         volumeSlider.value = volumeValus;
//         AudioListener.volume = volumeValus;
//     }
// }
