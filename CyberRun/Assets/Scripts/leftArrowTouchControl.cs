using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftArrowTouchControl : MonoBehaviour
{
    CarMove mv;
    public GameObject Car;

    // Start is called before the first frame update
    void Start()
    {
        mv = Car.GetComponent<CarMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTouchDown()
    {
        mv.MoveLeft();
    }
}
