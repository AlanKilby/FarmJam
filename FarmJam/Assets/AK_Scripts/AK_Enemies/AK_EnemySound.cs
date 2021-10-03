using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_EnemySound : MonoBehaviour
{
    public AudioClip HURT;
    public AudioClip DEATH;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
    }

    public void PlaySoundOS(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}
