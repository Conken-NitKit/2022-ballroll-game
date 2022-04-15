using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
/// <summary>
/// X値で動く床のスクリプト
/// </summary>
public class MoveXGroundController : MonoBehaviour
{
    [SerializeField] private float time;
    [SerializeField] private float plusX;
    private float positionY;
    private float positionZ;

    void Start()
    {
        positionZ = this.transform.position.z;
        positionY = this.transform.position.y;
        this.transform.DOMove(new Vector3(plusX, positionY, positionZ), time).SetLoops(1000000, LoopType.Yoyo);
    }
}