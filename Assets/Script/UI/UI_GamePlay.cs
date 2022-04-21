using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_GamePlay : MonoBehaviour
{

    public int score;
    public Text CurrentScore;
    public Text CurrentScoreEnd;
    public UI_Menu PausePLayGame;
    

    [SerializeField] private Button _pauseGame;
    [SerializeField] private Button _addScore;
    [SerializeField] private Button _resetGame;
    [SerializeField] private Button _pauseResetGame;
    [SerializeField] private Button _endResetGame;
    [SerializeField] private Button _menuNewGame;


    void Start()
    {
        score = 0;
    }
    void Update()
    {
        CurrentScore.text = score.ToString();
        CurrentScoreEnd.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighestScore"))
            PlayerPrefs.SetInt("HighestScore", score);
    }


    private void OnEnable()
    {
        _pauseGame.onClick.AddListener(HideAndOpenMenu);
        _addScore.onClick.AddListener(AddScoreButton);

        _pauseResetGame.onClick.AddListener(ResetGame);
        // _menuNewGame.onClick.AddListener(Reset);

        _resetGame.onClick.AddListener(OpenPanelReset);
        _endResetGame.onClick.AddListener(ResetGame);


    }
    public void AddScoreButton()
    {
        score += 1;
    }
    
    public void HideAndOpenMenu()
    {
        ControllerUI.Instance.PauseGame.gameObject.SetActive(true);
        CurrentScore.text = score.ToString();
        PausePLayGame.PlayGame = false;
    }
    public void ResetGame()
    {
        ControllerUI.Instance.PauseGame.gameObject.SetActive(false);
        ControllerUI.Instance.EndGame.gameObject.SetActive(false);
        score = 0;
    }
    public void OpenPanelReset()
    {
        ControllerUI.Instance.EndGame.gameObject.SetActive(true);
    }
    

}
