using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public ScoreManager Sm; //ヒエラルキーのScoreManagerと紐づける
    private int Status;

    private void OnTriggerEnter(Collider other)
    {
        if (Status == 0)
        {
            Sm.Score += 100;
            Destroy(this.gameObject); //オブジェクトが消えたときにスコア加算
        }
    }
    void Start()
    {
        Sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        Status = 0;
    }
}
