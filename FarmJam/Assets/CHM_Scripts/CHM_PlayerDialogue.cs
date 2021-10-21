using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHM_PlayerDialogue : MonoBehaviour
{
    public int dialogueProbabilty;

    public AudioSource audioSource;

    public AudioClip[] DialogueBox;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void TriggerDialogue()
    {
        int i = Random.Range(1, 100);

        if(i <= dialogueProbabilty)
        {
            int r = Random.Range(0, DialogueBox.Length);
            audioSource.PlayOneShot(DialogueBox[r]);
        }
        
    }
}
