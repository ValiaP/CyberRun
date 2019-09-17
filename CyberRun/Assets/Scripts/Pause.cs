using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject musicSource;
    public GameObject canv;
    public Animator anim;
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
        canv.SetActive(paused);
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == false)
            {
                StartCoroutine(LowPitch());                
                paused = true;
            }
            else
            {
                StartCoroutine(HighPitch());
                paused = false;
            }
        }
    }

    IEnumerator LowPitch()
    {
        if (!paused)
        {
            for (int i = 0; i < 10; i++)
            {
                src.pitch -= 0.05f;
                Time.timeScale -= 0.09999f;
                yield return new WaitForSecondsRealtime(0.1f);
            }

        }
    }

    IEnumerator HighPitch()
    {
        if (paused)
        {
            for (int i = 0; i < 10; i++)
            {
                src.pitch += 0.05f;
                Time.timeScale += 0.1f;
                yield return new WaitForSecondsRealtime(0.1f);
            }
         
        }
    }
}
