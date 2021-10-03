using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_BBQ : MonoBehaviour
{
    public int bbqPrice;
    AK_ScoreManager scoreManager;

    public GameObject playerAkimbo;

    public GameObject[] recipe;

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<AK_ScoreManager>();
        scoreManager.bacon = 0;
        scoreManager.eggs = 0;
        scoreManager.milk = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AK_PlayerScoringSystem playerScore = collision.gameObject.GetComponent<AK_PlayerScoringSystem>();

            if(playerScore.bacon >= bbqPrice && playerScore.eggs >= bbqPrice && playerScore.milk >= bbqPrice) 
            {
                scoreManager.bacon -= bbqPrice;
                scoreManager.eggs -= bbqPrice;
                scoreManager.milk -= bbqPrice;

                Vector2 playerPos = collision.gameObject.transform.position;

                for(int i = 0; i <= recipe.Length; i++)
                {
                    recipe[i].SetActive(false);
                }

                Destroy(collision.gameObject);

                Instantiate(playerAkimbo, playerPos, Quaternion.identity);
            }
        }
    }
}
