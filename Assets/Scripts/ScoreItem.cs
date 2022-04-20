using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public ScoreManager Sm; //�q�G�����L�[��ScoreManager�ƕR�Â���
    private int Status;

    private void OnTriggerEnter(Collider other)
    {
        if (Status == 0)
        {
            Sm.Score += 100;
            Destroy(this.gameObject); //�I�u�W�F�N�g���������Ƃ��ɃX�R�A���Z
        }
    }
    void Start()
    {
        Sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        Status = 0;
    }
}
