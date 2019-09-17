using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObstacleHit : MonoBehaviour
{
    AudioClip audioData;
  
    void Start()
    {
        audioData = GetComponent<AudioSource>().clip;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(audioData, this.gameObject.transform.position);

            //Destroy(other.gameObject);
            other.GetComponent<CarMove>().CarNormal.SetActive(false);
            other.GetComponent<CarMove>().CarDestroy.SetActive(true);
            StartCoroutine("SlowDown");
        }
        if (other.gameObject.CompareTag("Destructor"))
        {
            Destroy(gameObject);
        }
    }

    IEnumerator SlowDown()
    {
        while (true)
        {
            
            yield return new WaitForSecondsRealtime(0.1f);
            
            if(Time.timeScale >= 0.1f)
            {
                Time.timeScale -= 0.1f;
            }
            else
            {
                Time.timeScale = 0;
                yield break;
            }
        }
    }
}
