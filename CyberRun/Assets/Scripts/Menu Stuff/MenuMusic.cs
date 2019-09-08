using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    //notmanyideas, ask me whats wrong (i hope nothing)

    public AudioClip clickSFX;
    public AudioClip menuTheme;

    void Awake()
    {
        PlayTheme();
    }

    void PlayTheme()
    {
        AudioSource.PlayClipAtPoint(menuTheme, Camera.main.transform.position);
    }

    public void PlayClick()
    {
        AudioSource.PlayClipAtPoint(clickSFX, Camera.main.transform.position);
    }
}
