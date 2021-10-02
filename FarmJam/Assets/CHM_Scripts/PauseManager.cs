using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{



    void Update()
    {
        if(Input.GetButtonDown("pause"))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                Debug.Log("timeScale is now 0");
            }
            else
                Time.timeScale = 1;
            Debug.Log("timeScale is now 1");
        }
    }
}
