using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_DeathScreen : MonoBehaviour
{
    Camera cam;
    Canvas canvas;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = cam;
    }
}
