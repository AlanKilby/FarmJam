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
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySoundOS(AudioClip audioClip)
    {
        if (!audioSource.isPlaying)
            audioSource.PlayOneShot(audioClip);
    }
}
