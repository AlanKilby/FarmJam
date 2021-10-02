using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerHP : MonoBehaviour
{
    public float maxHP;

    public float playerHP;

    private void Start()
    {
        playerHP = maxHP;
    }
    
    public void LoseHP(float damage)
    {
        playerHP -= damage;
    }

    public void PlayerDeath()
    {
        if(playerHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
