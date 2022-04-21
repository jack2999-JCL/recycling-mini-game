using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Option : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button _exit;
    [SerializeField] public UI_GamePlay _gamePlayUI;
    // public bool OffAudio = true;
    // public Button panelAudio;

    private void OnEnable()
    {
        _exit.onClick.AddListener(HideAndOpenMenu);
    }

    public void HideAndOpenMenu()
    {
        this.gameObject.SetActive(false);
        
    }
    // void update()
    // {
    //     if(panelAudio.gameObject == true)
    //     {}
    // }
}
