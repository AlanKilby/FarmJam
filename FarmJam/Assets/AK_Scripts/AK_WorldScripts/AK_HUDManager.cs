using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AK_HUDManager : MonoBehaviour
{
    public Text eggsText;
    public Text milkText;
    public Text baconText;

    AK_ScoreManager scoreManager;
    Camera cam;
    Canvas canvas;

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<AK_ScoreManager>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = cam;
    }
    private void Update()
    {
        eggsText.text = " : " + scoreManager.eggs.ToString();
        milkText.text = " : " + scoreManager.milk.ToString();
        baconText.text = " : " + scoreManager.bacon.ToString();
    }
}
