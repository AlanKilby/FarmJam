using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{



    void Update()
    {
        if (Input.GetButtonDown("Pause") && Time.timeScale != 0)
        {

            Time.timeScale = 0;
            Debug.LogError("timeScale is now 0");
        }
        
        else if (Input.GetButtonDown("Pause") && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            Debug.LogError("timeScale is now 1");
        }
        
    }
}
