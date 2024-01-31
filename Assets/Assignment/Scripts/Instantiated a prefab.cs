using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiatedaprefab : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject MovingPlatformPrefab;
    public GameObject BouncingBallPrefab;

    void Start()
    {
        // Instantiate the player
        Instantiate(playerPrefab, new Vector2(0, 0), Quaternion.identity);

        // Instantiate the platform
        Instantiate(MovingPlatformPrefab, new Vector2(2, 0), Quaternion.identity);

        // Instantiate the bouncing object
        Instantiate(BouncingBallPrefab, new Vector2(-2, 0), Quaternion.identity);
    }
}