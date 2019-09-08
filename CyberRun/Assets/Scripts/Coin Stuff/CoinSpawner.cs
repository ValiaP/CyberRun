using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    //@Amazur / Mee6, NotManyIdeas;
    //To do:
    //Generate X coins in a row where X random
    //After X coins generate obstacle prefab
    //Switch PosXOffset


    public GameObject prefab; //coin prefab
    public Vector3 spawnPos; //spawning position of the coin
    float[] xLane = new float[] { -1, 0, 1 }; // array of x positions
    public float timeOffset = 0.5f; //during what time it spawns
    public float coinSpeed = 1f; //speed of the coin

    float rowAmount; //coins in a row
    Rigidbody rb;
    void Start()
    {
        InvokeRepeating("Spawn", 0,timeOffset);
    }

    void Spawn()
    {
        spawnPos.x = xLane[Random.Range(0, 3)]; //random x pos
        GameObject coin = Instantiate(prefab, spawnPos, Quaternion.identity);
        rb = coin.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, coinSpeed); //give velocity to coin
    }
}
