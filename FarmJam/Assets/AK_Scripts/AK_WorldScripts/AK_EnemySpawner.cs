using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    public bool isActive;

    public float timeBetweenSpawns;
    float timeHolder;

    public GameObject enemy;

    private void Start()
    {
        timeHolder = timeBetweenSpawns;
    }
    private void Update()
    {
        if(timeBetweenSpawns > 0 && isActive)
        {
            timeBetweenSpawns -= Time.deltaTime;
        }

        if(timeBetweenSpawns <= 0 && isActive)
        {
            SpawnEnemies();
        }
    }

    public void SpawnEnemies()
    {
        timeBetweenSpawns = timeHolder;

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(enemy);
        }
    }
}
