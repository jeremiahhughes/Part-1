using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollisionDetection : MonoBehaviour
{
     public int scoreValue = 10; 
    public GameObject player; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            CollectCoin();
        }
    }

    private void CollectCoin()
    {
        // Add to the player's score
        Debug.Log("Coin Collected! Score: " + scoreValue);
        //making the object disapear :)
        gameObject.SetActive(false);
    }
}