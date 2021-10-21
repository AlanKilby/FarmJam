using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }


    private void Update()
    {
        
    }
    public void LockMouse()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
