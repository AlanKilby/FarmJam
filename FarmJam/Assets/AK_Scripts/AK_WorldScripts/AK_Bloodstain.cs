using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_Bloodstain : MonoBehaviour
{
    public Sprite[] bloodstains;

    SpriteRenderer spriteRend;

    private void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.sprite = bloodstains[Random.Range(0, bloodstains.Length)];
    }
}
