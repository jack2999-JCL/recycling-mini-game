using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllHandle2 : MonoBehaviour
{
    [SerializeField] private float _force;
    private Rigidbody rb;
    private Vector3 _originalPos;
    private void Start() {
        rb = GetComponent<Rigidbody>();
        _originalPos = gameObject.transform.position;
    }
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100.0f)){
                if(hit.transform.gameObject.CompareTag("Handle2")){
                    Debug.Log("click");
                    Push();
                }
            }
        }
    }
    private void Push(){
        rb.AddForce(transform.right * _force);
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("EndPoint")){
            transform.position = _originalPos;
            rb.velocity = new Vector3(0,0,0);
            Debug.Log(transform.position);
        }
    }
}
