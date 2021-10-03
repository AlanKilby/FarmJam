using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerHP : MonoBehaviour
{
    public float maxHP;

    public float playerHP;

    public GameObject deathScreen;

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
        Instantiate(deathScreen,Vector2.zero,Quaternion.identity);
        Destroy(gameObject);
        Time.timeScale = 0;
    }
}
