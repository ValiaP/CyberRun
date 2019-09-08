using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    MenuMusic music;

    void Start()
    {
        music = FindObjectOfType<MenuMusic>();
    }
    public void MoveToNextScene()
    {
        music.PlayClick();
        var currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadGameScene()
    {
        music.PlayClick();
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        music.PlayClick();
        Application.Quit();
    }

}
