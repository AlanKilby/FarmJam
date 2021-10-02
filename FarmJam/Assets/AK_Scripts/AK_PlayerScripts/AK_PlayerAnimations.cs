using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerAnimations : MonoBehaviour
{
    public string PLAYER_IDLE;

    public string PLAYER_WALKING;

    string currentState;

    Animator animator;

    AK_PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = gameObject.GetComponent<AK_PlayerMovement>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(playerMovement.horizontalAxis != 0 || playerMovement.verticalAxis != 0)
        {
            ChangeAnimationState(PLAYER_WALKING);
        }
        else
        {
            ChangeAnimationState(PLAYER_IDLE);
        }
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }
}
