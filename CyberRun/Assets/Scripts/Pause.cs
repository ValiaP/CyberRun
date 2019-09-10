using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject musicSource;
    AudioSource src;
    bool paused;
    // Start is called before the first frame update
    void Start()
    {
        src = musicSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == false)
            {
                PauseGame();
                paused = true;
            }
            else
            {
                UnPauseGame();
                paused = false;

            }


        }
    }

    void PauseGame()
    {
        Time.timeScale = 0f;
        src.pitch = 0.5f;
    }
    void UnPauseGame()
    {
        Time.timeScale = 1f;
        src.pitch = 1f;
    }
}
