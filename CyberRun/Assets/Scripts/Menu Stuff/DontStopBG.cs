using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontStopBG : MonoBehaviour
{
    void Start()
    {

    }
    private static DontStopBG instance = null;
    public static DontStopBG Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}

