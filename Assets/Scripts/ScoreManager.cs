using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score;

    public Text ScoreText;

    void Start()
    {
        Score = -100;
    }

    void Update()
    {
        ScoreText.text = "Score:" + Score;
    }
}
