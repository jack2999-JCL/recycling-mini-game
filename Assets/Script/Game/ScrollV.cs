using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollV : MonoBehaviour
{
    [SerializeField] private float scrollX = 0;
    [SerializeField] private float scrollY = 0;
    public UI_Menu StartGame;
    private void Update()
    {
        if (StartGame.PlayGame == true)
        {
            float offsetX = Time.time * scrollX;
            float offsetY = Time.time * scrollY;
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, offsetY);
        }
    }
}
