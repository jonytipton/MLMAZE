using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    //Class handles Scorekeeping and Score display
    public int scoreCounter;
    public int maxScore;
    public TextMeshProUGUI currentScoreText;
    public GameObject keyImage;
    public bool hasKey;

    public void Start() //Score Rules & Setup
    {
        scoreCounter = 0;
        maxScore = 15;
        currentScoreText.text = (scoreCounter.ToString());
        hasKey = false;
        keyImage.SetActive(false);
    }
    public void ScorePoint() //Get Point function and Update display
    {
        scoreCounter += 1;
        currentScoreText.text = (scoreCounter.ToString());

        if (scoreCounter == maxScore) //Checks if max score is reached
        {
            hasKey = true;

            if (hasKey == true)
            {
                keyImage.SetActive(true);
            }
        }
    }
}
