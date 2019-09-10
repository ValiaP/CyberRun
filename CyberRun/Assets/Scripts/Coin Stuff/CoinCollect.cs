using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    AudioSource src;
    AudioClip audioData;
    public bool randomPitch = false;
    //@Mee6
    //Attach to coin prefab
    // Start is called before the first frame update
    void Start()
    {
        src = gameObject.GetComponent<AudioSource>();
        if (randomPitch==true)
        {
            src.pitch = Random.Range(-1f, 0.4f); //For randomly changing coin pitch
            audioData = src.clip;
        }
        else
        {
            audioData = src.clip;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            AudioSource.PlayClipAtPoint(audioData, this.gameObject.transform.position);
            Debug.Log("Collision detected");
            PlayerStats.coinAmount++;
            Debug.Log("Coin amount " + PlayerStats.coinAmount);
            Destroy(gameObject);
            
        }
        if (other.gameObject.CompareTag("Destructor"))
        {
            Debug.Log("Coin destruction");
            Destroy(gameObject);
        }
    }
}
