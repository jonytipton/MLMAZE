using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int ScoreCounter = 0;

    public void UpdateScore()
    {
        ScoreCounter += 1;
    }
}
