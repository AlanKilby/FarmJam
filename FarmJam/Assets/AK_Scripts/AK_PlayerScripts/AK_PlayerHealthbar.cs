using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AK_PlayerHealthbar : MonoBehaviour
{
    Image healthBar;
    float maxHealth;

    AK_PlayerHP playerHP;

    private void Start()
    {
        playerHP = GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerHP>();
        maxHealth = playerHP.maxHP;
        healthBar = GetComponent<Image>();
    }

    private void Update()
    {
        healthBar.fillAmount = playerHP.playerHP / maxHealth;
    }
}
