using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D playerRB;

    public float movementSpeed;
    public Camera cam;

    [HideInInspector]
    public float horizontalAxis;

    [HideInInspector]
    public float verticalAxis;

    Vector2 mousePos;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        playerRB = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        horizontalAxis = Input.GetAxisRaw("Horizontal");
        verticalAxis = Input.GetAxisRaw("Vertical");

        if(horizontalAxis != 0 || verticalAxis != 0)
        {
            playerRB.velocity = new Vector2(movementSpeed * horizontalAxis,movementSpeed * verticalAxis);
        }
        else
        {
            playerRB.velocity = Vector2.zero;
        }

        PlayerAim();
    }

    public void PlayerAim()
    {
        Vector2 lookDir = mousePos - playerRB.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90.0f;
        playerRB.rotation = angle;
    }
}
