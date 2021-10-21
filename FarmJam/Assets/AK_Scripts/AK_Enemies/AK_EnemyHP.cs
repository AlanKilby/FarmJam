using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_EnemyHP : MonoBehaviour
{
    public float maxHP;

    public float enemyHP;

    public bool isPig;
    public bool isChicken;
    public bool isCow;

    public int quantity;

    AK_EnemySound enemySound;

    bool isAlreadyDead = false;

    public GameObject bloodstain;

    private void Start()
    {
        enemyHP = maxHP;
        enemySound = GetComponent<AK_EnemySound>();
    }

    private void FixedUpdate()
    {
        if (enemyHP <= 0 && !isAlreadyDead)
        {
            EnemyDeath();
        }
    }

    public void LoseHP(float damage)
    {
        enemyHP -= damage;
        enemySound.PlaySoundOS(enemySound.HURT);
    }

    public void EnemyDeath()
    {
        isAlreadyDead = true;
        Instantiate(bloodstain, transform.position, Quaternion.identity);
        if (isPig)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerScoringSystem>().AddBacon(quantity);
            if(gameObject.GetComponent<AK_BigPigAI>() != null)
            {
                gameObject.GetComponent<AK_BigPigAI>().SpawnPigs();
            }
        }
        else if(isCow)
            GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerScoringSystem>().AddMilk(quantity);
        else if (isChicken)
            GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerScoringSystem>().AddEggs(quantity);

        GameObject.FindGameObjectWithTag("Player").GetComponent<AK_PlayerScoringSystem>().AddKill();
        Destroy(gameObject);
    }

    IEnumerator enemyDeathCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        
        yield return null;
    }
}
