using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void MoveToNextScene()
    {
        var currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    { 
        Application.Quit();
    }

}
