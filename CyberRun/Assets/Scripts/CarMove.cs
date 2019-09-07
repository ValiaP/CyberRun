using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    Vector3 trans;
    int index = 0;
    public float offset = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (index == -1) { }
            else
            {
                trans.x -= offset;
                gameObject.transform.position = trans;
                index--;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (index == 1) { }
            else
            {
                trans.x += offset;
                index++;
                gameObject.transform.position = trans;
            }
        }
    }
}
