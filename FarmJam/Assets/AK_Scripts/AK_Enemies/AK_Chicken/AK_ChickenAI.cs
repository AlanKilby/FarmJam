using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class AK_ChickenAI : MonoBehaviour
{
    AIPath aipath;
    AIDestinationSetter destination;

    public float chickenSpeed;

    private void Start()
    {
        aipath = GetComponent<AIPath>();
        aipath.maxSpeed = chickenSpeed;
        destination = GetComponent<AIDestinationSetter>();
        destination.target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
}
