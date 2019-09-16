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
            //todo all death stuff;
            print("obstacle collision");
            Destroy(other.gameObject);
            StartCoroutine(SlowDown());           
        }
        if (other.gameObject.CompareTag("Destructor"))
        {
            Debug.Log("Obstacle Destruction");
            Destroy(gameObject);
        }
    }

    IEnumerator SlowDown()
    {
        while(true)
        {
            if (Time.timeScale > 0f)
            {
                Time.timeScale -= 0.01f;
                yield return new WaitForSecondsRealtime(0.01f);
            }
            
        }

    }
}
