using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject groundPrefab;


    Rigidbody rb;
    public float groundSpeed = -10f;


    public float timeOffset = 10f;
    Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GroundSpawn", 0, timeOffset);
        spawnPos = new Vector3(0, -0.001f, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GroundSpawn()
    { 
            GameObject terrain = Instantiate(groundPrefab, spawnPos, Quaternion.identity);
            rb = terrain.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, groundSpeed); //give velocity to terrain
    }

}
