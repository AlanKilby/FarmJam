using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AK_ChickenAI : MonoBehaviour
{
    AIPath aipath;
    AIDestinationSetter destination;

    public float chickenSpeed;

    AK_EnemySound enemySound;

    float soundTimer = 3.5f;
    float holder;

    private void Start()
    {
        aipath = GetComponent<AIPath>();
        aipath.maxSpeed = chickenSpeed;
        destination = GetComponent<AIDestinationSetter>();
        destination.target = GameObject.FindGameObjectWithTag("Player").transform;
        enemySound = GetComponent<AK_EnemySound>();
        holder = soundTimer * 2;
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            enemySound.PlaySoundOS(enemySound.DEATH);
            Destroy(gameObject);
        }
    }

}
