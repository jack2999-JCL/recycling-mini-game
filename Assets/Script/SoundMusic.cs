using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundMusic : MonoBehaviour
{
    [SerializeField] Image soundOnIconMusic;
    [SerializeField] Image soundOffIconMusic;
    // [SerializeField] private GameObject _AudioMusic;
    // [SerializeField] private GameObject _AudioEffectPoint;
    // [SerializeField] private GameObject _AudioEffectPush;
    private bool muted = false;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted",0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
         AudioListener.pause = muted;
    }
    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
            //  _AudioMusic.gameObject.SetActive(true);
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
            //  _AudioMusic.gameObject.SetActive(false);
        }
        Save();
    }

    private void UpdateButtonIcon()
    {
        if(muted == false)
        {
            soundOnIconMusic.enabled = true;
            soundOffIconMusic.enabled = false;
        }
        else
        {
            soundOnIconMusic.enabled = false;
            soundOffIconMusic.enabled = true;
        }
    }
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }


}
