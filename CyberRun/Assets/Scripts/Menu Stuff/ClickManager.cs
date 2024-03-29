﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClickManager : MonoBehaviour
{

    public AudioClip click;

    public void ChangeSceneToGame()
    {
        AudioSource.PlayClipAtPoint(click, gameObject.transform.position);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        AudioSource.PlayClipAtPoint(click, gameObject.transform.position, 2f);
        Application.Quit();
    }
    public void ChangeSceneToMenu()
    {
        AudioSource.PlayClipAtPoint(click, gameObject.transform.position);
        Time.timeScale = 1f;

        SceneManager.LoadScene("MainMenu");
    }
    public void ChangeSceneToCredits()
    {
        AudioSource.PlayClipAtPoint(click, gameObject.transform.position);

        SceneManager.LoadScene("Credits");
    }
}
