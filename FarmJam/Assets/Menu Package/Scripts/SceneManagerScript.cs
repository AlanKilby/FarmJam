using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public string menuScene;
    public string playScene;

    public void PlayGame()
    {
        SceneManager.LoadScene(playScene);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(menuScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
