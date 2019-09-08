using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    AudioClip audioData;
    //@Mee6
    //Attach to coin prefab
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>().clip;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(audioData, this.gameObject.transform.position);
            Debug.Log("Collision detected");
            PlayerStats.coinAmount++;
            Debug.Log("Coin amount " + PlayerStats.coinAmount);
            Destroy(gameObject);
            
        }
        if (other.gameObject.tag == "Destructor")
        {
            Debug.Log("Coin destruction");
            Destroy(gameObject);
        }
    }
}
