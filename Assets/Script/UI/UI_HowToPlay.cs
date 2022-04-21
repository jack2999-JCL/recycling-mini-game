using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HowToPlay : MonoBehaviour
{
    [SerializeField] private Button _exit;

    private void OnEnable()
    {
        _exit.onClick.AddListener(HideAndOpenMenu);

    }

    public void HideAndOpenMenu()
    {
        this.gameObject.SetActive(false);
        ControllerUI.Instance.MenuGame.gameObject.SetActive(true);
    }
}
