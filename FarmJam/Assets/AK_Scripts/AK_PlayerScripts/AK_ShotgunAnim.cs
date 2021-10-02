using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_ShotgunAnim : MonoBehaviour
{
    public string GUN_IDLE;

    public string GUN_SHOOTING;

    string currentState;

    Animator animator;

    public AK_PlayerShooting playerShoot;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }


    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }

}
