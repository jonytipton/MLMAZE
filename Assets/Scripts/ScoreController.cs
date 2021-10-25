using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int scoreCounter;
    public int maxScore;
    public TextMeshProUGUI currentScoreText;
    public GameObject keyImage;
    public bool hasKey;

    public void Start()
    {
        scoreCounter = 0;
        maxScore = 15;
        currentScoreText.text = (scoreCounter.ToString());
        hasKey = false;
        keyImage.SetActive(false);
    }
    public void ScorePoint()
    {
        scoreCounter += 1;
        currentScoreText.text = (scoreCounter.ToString());

        if (scoreCounter == maxScore)
        {
            hasKey = true;

            if (hasKey == true)
            {
                keyImage.SetActive(true);
            }
        }
    }
}
