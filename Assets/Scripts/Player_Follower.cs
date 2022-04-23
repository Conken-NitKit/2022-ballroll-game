using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;

    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        this.transform.position = player.transform.position + offset;
    }
}
