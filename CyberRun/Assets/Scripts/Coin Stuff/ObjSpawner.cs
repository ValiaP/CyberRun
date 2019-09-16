using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawner : MonoBehaviour
{
    //@Amazur / Mee6, NotManyIdeas;
    //To do:
    //Generate X coins in a row where X random
    //After X coins generate obstacle prefab
    //Switch PosXOffset


    public GameObject coinPrefab; //coin prefab
    public GameObject obstaclePrefab; // obstacle prefab
    public GameObject emptyPrefab; // empty prefab
    public Vector3 spawnPos; //spawning position of the obj
    float[] xLane = new float[] { -1, 0, 1 }; // array of x positions
    float timeOffset = 0.5f; //during what time it spawns
    private float speed = -10; //speed of the obj

    Rigidbody rb;
    void Start()
    {
        InvokeRepeating("Spawn", 0, timeOffset);
        StartCoroutine(AddDifficulty());
    }

    void Spawn()
    {
        GameObject[] objToSpawn = new GameObject[] { coinPrefab, obstaclePrefab, emptyPrefab };
        spawnPos.x = xLane[Random.Range(0, 3)]; //random x pos
        GameObject objClone = Instantiate(objToSpawn[Random.Range(0, 3)], spawnPos, Quaternion.identity);
        rb = objClone.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, speed); //give velocity to obj       
    }

    IEnumerator AddDifficulty()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(1f); //hardcoded :(
            speed -= 0.5f;
            timeOffset = 0.01f;
            //print(timeOffset);
           // print(speed);
        }
    }
}
