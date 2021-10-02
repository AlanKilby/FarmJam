using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_LockedDoor : MonoBehaviour
{
    public int doorPrice;
    public bool bacon;
    public bool milk;
    public bool eggs;

    public AK_EnemySpawner[] linkedSpawners;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AK_PlayerScoringSystem playerScore = collision.gameObject.GetComponent<AK_PlayerScoringSystem>();

            if (bacon && playerScore.bacon >= doorPrice)
            {
                playerScore.bacon -= doorPrice;
                OpenDoor();
            }
            else if (milk && playerScore.milk >= doorPrice)
            {
                playerScore.milk -= doorPrice;
                OpenDoor();
            }
            else if (eggs && playerScore.eggs >= doorPrice)
            {
                playerScore.eggs -= doorPrice;
                OpenDoor();
            }
        }
    }

    public void OpenDoor()
    {
        if(linkedSpawners != null)
        {
            for (int i = 0; i < linkedSpawners.Length; i++)
            {
                linkedSpawners[i].isActive = true;
            }
        }
        
        Destroy(gameObject);
    }
}
