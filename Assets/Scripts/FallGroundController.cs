using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// プレイヤーが地面と接触した際に落ちるスクリプト
/// </summary>
public class FallGroundController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    [SerializeField] private float speed;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb.velocity = new Vector3(0, -speed, 0);
        }

    }
}
