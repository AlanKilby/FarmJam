using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerScoringSystem : MonoBehaviour
{
    public int eggs;
    public int bacon;
    public int milk;

    private void Start()
    {
        eggs = 0;
        bacon = 0;
        milk = 0;
    }

    public void AddMilk()
    {
        milk++;
    }

    public void AddBacon()
    {
        bacon++;
    }

    public void AddEggs()
    {
        eggs++;
    }
}
