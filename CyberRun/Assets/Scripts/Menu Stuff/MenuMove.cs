using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class MenuMove : MonoBehaviour
{
    Vector3 trans;
    public int index = 0;
    public float offset = 0.8f;
    public Ease Ease = Ease.InOutBounce;
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (index == -1) { }
            else
            {
                MoveLeft();
            }
            
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (index == 1) { }
            else
            {
                MoveRight();
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            switch (index)
            {
                case -1:
                    Application.Quit();
                    break;
                case 0:
                    SceneManager.LoadScene("Game");
                    break;
                case 1:
                    SceneManager.LoadScene("Credits");
                    break;
            }

        }

    }

    public void MoveLeft()
    {
        index--;

        transform.DOMoveX(index * offset, 0.3f).SetEase(Ease);
        DOTween.Sequence().Append(transform.DORotate(new Vector3(0, -5, 0), 0.15f)).Append(transform.DORotate(new Vector3(0, 0, 0), 0.15f));
    }
    void MoveRight()
    {
        index++;

        transform.DOMoveX(index * offset, 0.3f).SetEase(Ease);
        DOTween.Sequence().Append(transform.DORotate(new Vector3(0, 5, 0), 0.15f)).Append(transform.DORotate(new Vector3(0, 0, 0), 0.15f));


    }
}
