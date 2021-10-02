using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class AK_BigPigAI : MonoBehaviour
{
    AIPath aipath;
    AIDestinationSetter destination;

    public float pigSpeed;

    public Transform[] spawnPoints;

    AK_EnemyHP enemyHP;
    public GameObject pigToSpawn;

    private void Start()
    {
        enemyHP = this.GetComponent<AK_EnemyHP>();
        aipath = GetComponent<AIPath>();
        aipath.maxSpeed = pigSpeed;
        destination = GetComponent<AIDestinationSetter>();
        destination.target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        if(enemyHP.enemyHP <= 0)
        {
            SpawnPigs();
        }
    }

    public void SpawnPigs()
    {
        for(int i = 0; i < spawnPoints.Length; i++)
        {
            Instantiate(pigToSpawn, spawnPoints[i].position, Quaternion.Euler(transform.localEulerAngles));
        }
    }
}
