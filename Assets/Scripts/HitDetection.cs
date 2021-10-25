using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitDetection : MonoBehaviour
{
    public ScoreController scoreCon;
    public GameObject collectable;

    void OnCollisionEnter(Collision collision)
    {
        //Script is attached to Pickups to see if th player bumps into it.

        if (collision.gameObject.name == "Player")
        {
            
            //If they hit the pickup, their score goes up and the pickup deletes itself.

            scoreCon.ScorePoint();
            Debug.Log(scoreCon.scoreCounter);

            GameObject.Destroy(collectable);
        }

        //Testing different forms of collision
        if (collision.gameObject.tag == "collectable")
        {
            
        }
        if (collision.gameObject.layer == 9)
        {
          
        }
    }
}
