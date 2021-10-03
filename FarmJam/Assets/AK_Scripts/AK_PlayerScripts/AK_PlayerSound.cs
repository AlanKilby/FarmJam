using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK_PlayerSound : MonoBehaviour
{
    public AudioClip SHOOTING;
    public AudioClip HURT;

    AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void PlaySoundOS(AudioClip audioClip)
    {
        audioSrc.PlayOneShot(audioClip);
    }
}
