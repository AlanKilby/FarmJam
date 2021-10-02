using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class AK_SmallPigAI : MonoBehaviour
{
    AIPath aipath;
    AIDestinationSetter destination;

    public float pigSpeed;

    private void Start()
    {
        aipath = GetComponent<AIPath>();
        aipath.maxSpeed = pigSpeed;
        destination = GetComponent<AIDestinationSetter>();
        destination.target = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
