using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ステージを自動で生成するスクリプト
/// </summary>
public class GenerateStage : MonoBehaviour
{
    [SerializeField] private GameObject[] stage;
    [SerializeField] private GameObject goal;

    private int randomNumber;
    private int spawnPointZ = 5;
    private int spawnPointY = -1;
    [SerializeField] private int groundAmount;

    void Start()
    {
        Instantiate(stage[0], new Vector3(0, -1, 0), Quaternion.identity);
        for(int i = 0; i < groundAmount;i++,spawnPointZ += 5)
        {
            randomNumber = Random.Range(0, stage.Length);
            Instantiate(stage[randomNumber], new Vector3(0, spawnPointY, spawnPointZ), Quaternion.identity);
            if(randomNumber == 1)
            {
                spawnPointY -= 2;
            }
            if(randomNumber == 3)
            {
                spawnPointY += 2;
            }
            if(i == groundAmount - 1)
            {
                spawnPointZ += 5;
                Instantiate(goal, new Vector3(0, spawnPointY, spawnPointZ), Quaternion.identity);
            }
        }
        
    }
}
