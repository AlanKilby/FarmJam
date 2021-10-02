using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Pellet : MonoBehaviour
{
    public float pelletSpeed;

    Transform bulletTransform;

    Rigidbody2D bulletRB;


    private void Start()
    {
        bulletTransform = gameObject.GetComponent<Transform>();
        bulletRB = GetComponent<Rigidbody2D>();
        bulletRB.AddForce(transform.up * pelletSpeed, ForceMode2D.Impulse);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Wall"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            Destroy(gameObject);
        }
    }

}