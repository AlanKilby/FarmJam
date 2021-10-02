using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_DamageZone : MonoBehaviour
{
    public float contactDamage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            AK_PlayerHP playerHP = collision.GetComponent<AK_PlayerHP>();
            playerHP.LoseHP(contactDamage);
        }
    }
}
