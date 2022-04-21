using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerUI : MonoBehaviour
{
    public static ControllerUI Instance;
    [SerializeField] public UI_Menu MenuGame;
    [SerializeField] public UI_Option OptionGame;
    [SerializeField] public UI_About AboutGame;
    [SerializeField] public UI_Pause PauseGame;
    [SerializeField] public UI_HighScore HighScore;
    [SerializeField] public UI_GamePlay GamePlayUI;
    [SerializeField] public UI_End EndGame;
    
    [SerializeField] public UI_HowToPlay HowToPlay;
    [SerializeField] public GameObject audio;
    // [SerializeField] public 

     private void Awake() {
         if(Instance ==null){
             Instance = this;
         }
         else{
             Destroy(gameObject);
         }
     }
    private void Start() 
    {
        
        MenuGame.gameObject.SetActive(true);
        GamePlayUI.gameObject.SetActive(false);
        audio.gameObject.SetActive(false);
        HowToPlay.gameObject.SetActive(false);
        OptionGame.gameObject.SetActive(false);
        AboutGame.gameObject.SetActive(false);
        PauseGame.gameObject.SetActive(false);
        HighScore.gameObject.SetActive(false);  
        EndGame.gameObject.SetActive(false); 
    }
}
