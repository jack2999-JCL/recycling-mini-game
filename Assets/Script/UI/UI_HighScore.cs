using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HighScore : MonoBehaviour
{
    public Text HighestScore;
    public Text SaveHighestScore;
    [SerializeField] private Button _resetScore;
    // Start is called before the first frame update
    [SerializeField] private Button _exit;
    private void OnEnable()
    {
        _exit.onClick.AddListener(HideAndOpenMenu);
           _resetScore.onClick.AddListener(Reset);

    }
    public void HideAndOpenMenu()
    {
        this.gameObject.SetActive(false);
        ControllerUI.Instance.MenuGame.gameObject.SetActive(true);
        ControllerUI.Instance.GamePlayUI.gameObject.SetActive(false);
    }
    
    void Start()
    {
       HighestScore.text =  PlayerPrefs.GetInt("HighestScore").ToString();
       HighestScore = SaveHighestScore;
    }
    
    private void Reset()
    {
        PlayerPrefs.DeleteAll();
        HighestScore.text = "0";
    }
}
