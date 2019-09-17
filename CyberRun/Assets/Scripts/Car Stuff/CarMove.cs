using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CarMove : MonoBehaviour
{
    Vector3 trans;
    public int index = 0;
    public float offset = 0.8f;
    public Ease Ease = Ease.InOutBounce;
    public GameObject CarDestroy, CarNormal;
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
