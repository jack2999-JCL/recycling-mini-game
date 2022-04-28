using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField] private GameObject _AudioGame;
    public AdsController _Ads;
    public UI_Menu PausePlayGame;
    public GameObject[] Hearts;
    private int Life;
    private bool Dead;


    private void Start()
    {
        Life = Hearts.Length;
    }
    void Update()
    {
        if (Dead == true)
        {
            _Ads.Show_InterstitiaAd();
            

            ControllerUI.Instance.EndGame.gameObject.SetActive(true);
            PausePlayGame.PlayGame = false;
            _AudioGame.gameObject.SetActive(false);
            // Dead = true;
        }
    }
    public void TakeDamage(int Dame)
    {
        Life -= Dame;
        Hearts[Life].SetActive(false);
        // Destroy(Hearts[Life].gameObject);
        if (Life < 1)
        {
            Dead = true;
        }
    }

}
