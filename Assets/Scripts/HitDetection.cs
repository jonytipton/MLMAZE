using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitDetection : MonoBehaviour
{
    public ScoreController scoreCon;
    public GameObject collectable;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(scoreCon.ScoreCounter);

        if (collision.gameObject.name == "Player")
        {
            
            Debug.Log("Player Hit");

            scoreCon.UpdateScore();
            Debug.Log(scoreCon.ScoreCounter);

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
