using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    public GameObject groundPrefab; //GROUND GRID
    public GameObject mountainPrefab; //MOUNTAINS


    Rigidbody rb;
    public float groundSpeed = -10f;


    public float timeOffset = 10f;
    Vector3 spawnPos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GroundSpawn", 0, timeOffset);
        InvokeRepeating("MountainSpawn", 0, timeOffset/5);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GroundSpawn() //THIS SHIT IS PURELY FOR GRIDS
    { 
            spawnPos = new Vector3(0, -0.001f, 100);
            GameObject terrain = Instantiate(groundPrefab, spawnPos, Quaternion.identity);
            rb = terrain.GetComponent<Rigidbody>();
            rb.velocity = new Vector3(0, 0, groundSpeed); //give velocity to terrain
    }

    void MountainSpawn() //IS IS FOR SPAWNING MOUNTAINS
    {
        //BASICALLY THIS CODE IS PURE SHIT
        //INSTANTIATES TWO MOUNTAINS - MIGHT WANT TO MAKE TWO MOUNTAINS INTO ONE PREFAB
        //@MEE6
        spawnPos = new Vector3(-35, -0.1f, 100);
        GameObject terrain = Instantiate(mountainPrefab, spawnPos, Quaternion.identity); //spawn left one
        rb = terrain.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, groundSpeed); //give velocity to left mountain
        spawnPos = new Vector3(35, -0.1f, 100);
        terrain = Instantiate(mountainPrefab, spawnPos, Quaternion.identity); //spawn right one
        rb = terrain.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, groundSpeed); //give velocity to right mountain

    }
}
