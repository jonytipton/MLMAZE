using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitDetectionDoor : MonoBehaviour
{
    public ScoreController scoreCon;
    public GameObject door;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            Debug.Log("door hit");
            //win the game, woot woot!
            scoreCon.hasKey = false;
            scoreCon.keyImage.SetActive(false);
        }
    }
}
