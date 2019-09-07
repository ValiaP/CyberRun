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
    public float spawnPosXoffset = 0.8f; //offset of the X of the coin - "which lane it spawns on"
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
        /*  int lane = Random.Range(-2, 2);
          switch(lane)
          {
              case 1:
                  spawnPosXoffset *= 1;
                  break;
              case 0:
                  spawnPosXoffset = 0;
                  break;
              case -1:
                  spawnPosXoffset *= -1;
                  break;
          }*/


        int lane = Random.Range(-1, 1);
        Debug.Log(lane);
        if (lane == -1)
        {
            spawnPosXoffset = -spawnPosXoffset;
        }
        else
        {
            spawnPosXoffset = 0;
        }


        spawnPos.x = spawnPosXoffset;
        GameObject coin = Instantiate(prefab, spawnPos, Quaternion.identity);
        rb = coin.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, coinSpeed); //give velocity to coin
    }
}
