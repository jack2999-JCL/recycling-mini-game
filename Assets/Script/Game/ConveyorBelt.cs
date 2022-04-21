using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    //[SerializeField] private GameObject belt;
    //[SerializeField] private Transform endPoint;
    [SerializeField] private float CurrSpeed;
    [SerializeField] private float MaxSpeed;
    [SerializeField] private Rigidbody rb;
    public UI_Menu StartGame;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (StartGame.PlayGame == true)
        {
             CurrSpeed = Mathf.Lerp(CurrSpeed, MaxSpeed, 0.000001f);
            // other.transform.position = Vector3.MoveTowards(other.transform.position, endPoint.position, speed*Time.deltaTime);
            Vector3 pos = rb.position;
            rb.position += Vector3.back * CurrSpeed * Time.fixedDeltaTime;
            rb.MovePosition(pos);
        }
    }
}
