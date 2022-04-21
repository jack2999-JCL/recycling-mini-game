using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Menu : MonoBehaviour
{
    [SerializeField] private Button _startGame;
    [SerializeField] private Button _highScore;
    [SerializeField] private Button _optionGame;
    [SerializeField] private Button _aboutGame;
    [SerializeField] private Button _exitGame;
    [SerializeField] private Button _howToPlay;
    [SerializeField] private GameObject _AudioGame;

    public bool PlayGame = false;
    
    public void Start()
    {
       PlayGame = false;
    }
    private void OnEnable()
    {   
        _startGame.onClick.AddListener(HideAndOpenGame);
        _highScore.onClick.AddListener(OpenHighScore);
        _optionGame.onClick.AddListener(OpenOption);
        _aboutGame.onClick.AddListener(OpenAbout);
      _howToPlay.onClick.AddListener(OpenHowToPlay);
       
      //   _startGame.onClick.AddListener(Hide);
      //   _highScore.onClick.AddListener(Hide);
      // //   _optionGame.onClick.AddListener(Hide);
      //   _aboutGame.onClick.AddListener(Hide);
         _exitGame.onClick.AddListener(QuitGame);

    }
   private void OpenHowToPlay()
   {
      ControllerUI.Instance.HowToPlay.gameObject.SetActive(true);
      this.gameObject.SetActive(false);
   }
    private void OpenHighScore()
    {
       ControllerUI.Instance.HighScore.gameObject.SetActive(true);
       this.gameObject.SetActive(false);
    }
    private void OpenOption()
    {
       ControllerUI.Instance.OptionGame.gameObject.SetActive(true);
      //  this.gameObject.SetActive(false);
    }
    private void OpenAbout()
    {
       ControllerUI.Instance.AboutGame.gameObject.SetActive(true);
       this.gameObject.SetActive(false);
    }
    
    public void HideAndOpenGame()
    {
       _AudioGame.gameObject.SetActive(true);
      this.gameObject.SetActive(false);
      ControllerUI.Instance.GamePlayUI.gameObject.SetActive(true);
      PlayGame = true;
    }
    public void QuitGame()
    {
       Application.Quit();
       Debug.Log("quit");
    }
}
