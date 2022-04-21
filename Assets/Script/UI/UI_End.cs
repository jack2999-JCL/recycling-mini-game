using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI_End : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Button _exit;
    [SerializeField] private Button _continue;
    
    // [SerializeField] private GameObject _health;
    // public UI_Menu ContinueGame;
    // public HealthController health;


    private void OnEnable()
    {
        _exit.onClick.AddListener(Quit);
        _continue.onClick.AddListener(HideAndOpenMenu);
    }
    public void HideAndOpenMenu()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
       Application.Quit();
       Debug.Log("quit");
    }
}
