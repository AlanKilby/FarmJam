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
    AK_ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<AK_ScoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //AK_PlayerScoringSystem playerScore = collision.gameObject.GetComponent<AK_PlayerScoringSystem>();

            if (bacon && scoreManager.bacon >= doorPrice)
            {
                scoreManager.bacon -= doorPrice;
                OpenDoor();
            }
            else if (milk && scoreManager.milk >= doorPrice)
            {
                scoreManager.milk -= doorPrice;
                OpenDoor();
            }
            else if (eggs && scoreManager.eggs >= doorPrice)
            {
                scoreManager.eggs -= doorPrice;
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
