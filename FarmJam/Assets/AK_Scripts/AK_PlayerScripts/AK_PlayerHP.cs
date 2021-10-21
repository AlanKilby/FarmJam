using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerHP : MonoBehaviour
{
    public float maxHP;

    public float playerHP;

    public GameObject deathScreen;

    public GameObject playerDummy;

    AK_PlayerSound playerSound;

    private void Start()
    {
        playerHP = maxHP;
        playerSound = GetComponent<AK_PlayerSound>();
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
        playerSound.PlaySoundOS(playerSound.HURT);
    }

    public void PlayerDeath()
    {
        Instantiate(deathScreen,Vector2.zero,Quaternion.identity);
        Instantiate(playerDummy,transform.position,Quaternion.identity);
        Destroy(gameObject);
        
    }
}
