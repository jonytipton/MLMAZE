using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int scoreCounter;
    public TextMeshProUGUI currentScoreText;

    public void Start()
    {
        scoreCounter = 0;
        currentScoreText.text = (scoreCounter.ToString());
    }
    public void ScorePoint()
    {
        scoreCounter += 1;
        currentScoreText.text = (scoreCounter.ToString());
    }
}
