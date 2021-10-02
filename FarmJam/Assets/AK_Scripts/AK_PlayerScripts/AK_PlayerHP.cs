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

    private void Update()
    {
        if (playerHP <= 0)
        {
            PlayerDeath();
        }
    }
    public void LoseHP(float damage)
    {
        playerHP -= damage;
    }

    public void PlayerDeath()
    {
        Destroy(gameObject);
    }
}
