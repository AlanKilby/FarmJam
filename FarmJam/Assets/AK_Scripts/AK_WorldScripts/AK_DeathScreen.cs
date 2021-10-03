using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AK_DeathScreen : MonoBehaviour
{
    Camera cam;
    Canvas canvas;
    public Scene activeScene;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = cam;
        activeScene = SceneManager.GetActiveScene();

        //Time.timeScale = 0;
    }

}
