using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AK_Buttons : MonoBehaviour
{

    public string playScene;
    public string creditsScene;
    public string mainMenu;
    public Scene activeScene;

    private void Start()
    {
        activeScene = SceneManager.GetActiveScene();

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(playScene);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(activeScene.buildIndex);
    }

    public void Credits()
    {
        SceneManager.LoadScene(creditsScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}

