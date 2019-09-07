using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    //@Amazur / Mee6
    //To do:
    //Generate X coins in a row where X random
    //After X coins generate obstacle prefab
    //Switch PosXOffset


    public GameObject prefab; //coin prefab
    public Vector3 spawnPos; //spawning position of the coin
    public float spawnPosXoffset = 0.7f; //offset of the X of the coin - "which lane it spawns on"
    public float timeOffset = 0.5f; //during what time it spawns
    public float coinSpeed = 1f; //speed of the coin
    Rigidbody rb;
    void Start()
    {
        InvokeRepeating("Spawn", 0,timeOffset);
    }

    void Spawn()
    {
        GameObject coin = Instantiate(prefab, spawnPos, Quaternion.identity);
        rb = coin.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, coinSpeed);
    }
}
