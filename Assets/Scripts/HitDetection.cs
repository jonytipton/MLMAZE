using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitDetection : MonoBehaviour
{
    public ScoreController scoreCon;
    public GameObject collectable;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(scoreCon.scoreCounter);

        if (collision.gameObject.name == "Player")
        {
            
            Debug.Log("Player Hit");

            scoreCon.ScorePoint();
            Debug.Log(scoreCon.scoreCounter);

            GameObject.Destroy(collectable);
        }

        
        if (collision.gameObject.tag == "collectable")
        {
            
            Debug.Log("Tag Hit");
        }
        if (collision.gameObject.layer == 9)
        {
            Debug.Log("Layer hit");
        }
    }
}
