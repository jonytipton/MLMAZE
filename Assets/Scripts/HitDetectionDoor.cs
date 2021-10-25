using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitDetectionDoor : MonoBehaviour
{
    public ScoreController scoreCon;
    public GameObject door;

    void OnCollisionEnter(Collision collision)
    {
        //Script is attached to the door and checks if the player bumps into it
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("door hit");
            //If the player has the key, they can win the game here.
            scoreCon.hasKey = false;
            scoreCon.keyImage.SetActive(false);
        }
    }
}
