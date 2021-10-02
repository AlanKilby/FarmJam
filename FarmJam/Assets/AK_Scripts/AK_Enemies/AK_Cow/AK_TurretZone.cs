using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_TurretZone : MonoBehaviour
{
    public AK_CowAI cowAI;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !cowAI.turretMode)
        {
            cowAI.TurretActivated();
        }
    }
}
