using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    //notmanyideas, ask me whats wrong (i hope nothing)

    public AudioClip clickSFX;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        clickSFX = gameObject.GetComponent<AudioSource>().clip;      
    }
}
