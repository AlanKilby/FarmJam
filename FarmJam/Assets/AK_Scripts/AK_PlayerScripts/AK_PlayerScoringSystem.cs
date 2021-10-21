using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerScoringSystem : MonoBehaviour
{
    public int eggs;
    public int bacon;
    public int milk;
    public int enemyKilled;

    AK_ScoreManager scoreManager;

    
    private void Update()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<AK_ScoreManager>();
        eggs = scoreManager.eggs;
        milk = scoreManager.milk;
        bacon = scoreManager.bacon;
        enemyKilled = scoreManager.enemyKilled;

    }
    public void AddMilk(int quantity)
    {
        scoreManager.milk += quantity;
    }

    public void AddBacon(int quantity)
    {
        scoreManager.bacon+= quantity;
    }

    public void AddEggs(int quantity)
    {
        scoreManager.eggs += quantity;
    }

    public void AddKill()
    {
        scoreManager.enemyKilled += 1;
    }
}
