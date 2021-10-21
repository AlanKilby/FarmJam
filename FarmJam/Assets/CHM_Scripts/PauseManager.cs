using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public bool isPaused;

    public MouseManager mouseManager;

    public GameObject pauseButton;
    private void Start()
    {
        isPaused = false;
        mouseManager.GetComponent<MouseManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale != 0)
        {

            Time.timeScale = 0;
            Debug.LogError("timeScale is now 0");
            mouseManager.UnlockMouse();
            pauseButton.SetActive(true);

        }
        
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Debug.LogError("timeScale is now 1");
            mouseManager.LockMouse();
            pauseButton.SetActive(false);
        }
        
    }


    public void PauseButton()
    {
        Time.timeScale = 1;
        Debug.LogError("timeScale is now 1");
        mouseManager.LockMouse();
    }
}
