using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_Pause : MonoBehaviour
{

    [SerializeField] private Button _continue;
    [SerializeField] private Button _restart;
    [SerializeField] private Button _exit;
    [SerializeField] private Button _option;
    public UI_Menu ContinueGame;
    // public UI_GamePlay UI_GamePlay;
    
    private void OnEnable()
    {
        _continue.onClick.AddListener(HideAndBackGame);
        _restart.onClick.AddListener(HideAndOpenMenu);
        _restart.onClick.AddListener(Hide);
        _option.onClick.AddListener(HideAndOpenOption);
        _exit.onClick.AddListener(HideAndOpenMenu);
    }

    public void HideAndBackGame()
    {
        this.gameObject.SetActive(false);
        ContinueGame.PlayGame = true;
    }
    public void HideAndOpenOption()
    {
        
        ControllerUI.Instance.OptionGame.gameObject.SetActive(true);
    }
    public void HideAndOpenMenu()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // this.gameObject.SetActive(false);
        // ControllerUI.Instance._menuGame.gameObject.SetActive(false);
        // ControllerUI.Instance._gamePlayUI.gameObject.SetActive(false);
       
    }
     public void Hide()
    {
       this.gameObject.SetActive(false);
    }

}
