using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Option : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button _exit;
    [SerializeField] public UI_GamePlay _gamePlayUI;


    // [SerializeField] private Button _offMusic;
    // [SerializeField] private Button _onMusic;
    // [SerializeField] private GameObject _iconMusicOff;
    // [SerializeField] private GameObject _iconMusicOn;


    // [SerializeField] private Button _offEffect;
    // [SerializeField] private Button _onEffect;
    // [SerializeField] private GameObject _IconEffectOff;
    // [SerializeField] private GameObject _IconEffectOn;


    [SerializeField] private AudioSource _AudioMusic;
    [SerializeField] private AudioSource _AudioEffectPoint;
    [SerializeField] private AudioSource _AudioEffectPush;
    // public bool OffAudio = true;
    // public Button panelAudio;

    

    private void Start()
    {

    }
    private void OnEnable()
    {
        _exit.onClick.AddListener(HideAndOpenMenu);
        // _offMusic.onClick.AddListener(OffPanelMusic);
        // _onMusic.onClick.AddListener(OnPanelMusic);

        // _offEffect.onClick.AddListener(OffPanelEffect);
        // _onEffect.onClick.AddListener(OnPanelEffect);
        

    }

    public void HideAndOpenMenu()
    {
        this.gameObject.SetActive(false);

    }
    
    // public void OffPanelEffect()
    // {
    //     _IconEffectOff.gameObject.SetActive(false);
    //     _IconEffectOn.gameObject.SetActive(true);
    //     _AudioMusic.gameObject.SetActive(false);
    // }
    // public void OnPanelEffect()
    // {
    //     _IconEffectOff.gameObject.SetActive(true);
    //     _IconEffectOn.gameObject.SetActive(false);
    //     _AudioMusic.gameObject.SetActive(true);
    // }
    // public void OffPanelMusic()
    // {
    //     _iconMusicOff.gameObject.SetActive(false);
    //     _iconMusicOn.gameObject.SetActive(true);
    //     _AudioEffectPoint.gameObject.SetActive(false);
    //     _AudioEffectPush.gameObject.SetActive(false);
    // }
    // public void OnPanelMusic()
    // {
    //     _iconMusicOff.gameObject.SetActive(true);
    //     _iconMusicOn.gameObject.SetActive(false);
    //     _AudioEffectPoint.gameObject.SetActive(true);
    //     _AudioEffectPush.gameObject.SetActive(true);
    // }

    


}
