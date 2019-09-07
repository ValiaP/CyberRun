﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject prefab; //coin prefab
    public Vector3 spawnPos; //spawning position of the coin
    public float spawnPosXoffset = 0.7f; //offset of the X of the coin - "which lane it spawns on"
    public float timeOffset = 0.5f; //during what time it spawns
    void Start()
    {
        InvokeRepeating("Spawn", 0,timeOffset);
    }

    void Spawn()
    {
        GameObject coin = Instantiate(prefab, spawnPos, Quaternion.identity);
    }
}
