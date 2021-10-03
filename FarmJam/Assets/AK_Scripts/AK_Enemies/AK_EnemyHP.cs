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


    private void Start()
    {
        enemyHP = maxHP;
    }

    private void FixedUpdate()
    {
        if (enemyHP <= 0)
        {
            EnemyDeath();
        }
    }

    public void LoseHP(float damage)
    {
        enemyHP -= damage;
    }

    public void EnemyDeath()
    {
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

        Destroy(gameObject);
    }

    IEnumerator enemyDeathCoroutine()
    {
        yield return new WaitForSeconds(0.1f);
        
        yield return null;
    }
}
