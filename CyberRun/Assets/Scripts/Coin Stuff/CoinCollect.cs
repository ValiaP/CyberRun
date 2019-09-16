using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityStandardAssets.ImageEffects;

public class CoinCollect : MonoBehaviour
{
    private float shakeDuration = 0f;
    private float shakeMagnitude = 0.7f;
    private float dampingSpeed = 1.0f;
    Vector3 initialPosition;



    public GameObject cam;
    private Fisheye eye;
    AudioSource src;
    AudioClip audioData;
    public TextMeshProUGUI coinText;
    public bool randomPitch = false;
    //@Mee6
    //Attach to coin prefab
    // Start is called before the first frame update
    void Start()
    {
        eye = cam.GetComponent<Fisheye>();
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

    void Update()
    {
        coinText.text = PlayerStats.coinAmount.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(audioData, this.gameObject.transform.position);
            Debug.Log("Collision detected");
            PlayerStats.coinAmount++;
            Debug.Log("Coin amount " + PlayerStats.coinAmount);
            StartCoroutine(Fisheye());
            Destroy(gameObject);
            
        }
        if (other.gameObject.CompareTag("Destructor"))
        {
            Debug.Log("Coin destruction");
            Destroy(gameObject);
        }
    }

    IEnumerator Fisheye()
    {
        eye.strengthX = 0.02f;
        eye.strengthY = 0.02f;
        yield return new WaitForSeconds(0.1f);
        eye.strengthX = 0;
        eye.strengthY = 0;
    }
}
