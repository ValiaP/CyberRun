using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDelete : MonoBehaviour
{
    Vector3 vec;
    void Start()
    {
    }
    void Update()
    {
        vec = gameObject.transform.position;
        if(-150 > vec.z)
        {
            Destroy(gameObject);
        }
    }
}
