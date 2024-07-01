using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMusicPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip audioClip;
    void Start()
    {
        audioSource=GetComponent<AudioSource>();
        audioSource.clip=audioClip;
        audioSource.Play();

    }

}
