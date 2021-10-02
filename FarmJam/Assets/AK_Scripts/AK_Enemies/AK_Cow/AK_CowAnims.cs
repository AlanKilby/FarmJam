using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_CowAnims : MonoBehaviour
{
    public string COW_WALKING;

    public string COW_TURRET;

    string currentState;

    Animator animator;

    public AK_CowAI cowAI;

    private void Start()
    {
        
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (!cowAI.turretMode)
        {
            ChangeAnimationState(COW_WALKING);
        }
        else
        {
            ChangeAnimationState(COW_TURRET);
        }
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        animator.Play(newState);

        currentState = newState;
    }
}
