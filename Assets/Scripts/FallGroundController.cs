using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �v���C���[���n�ʂƐڐG�����ۂɗ�����X�N���v�g
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
