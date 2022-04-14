using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
     float moveH = Input.GetAxis("Horizontal"); //水平方向に移動
     float moveV = Input.GetAxis("Vertical");  //垂直方向に移動

     Vector3 move = new Vector3(moveH, 0, moveV);
     rb.AddForce(move * speed); 
    }
}