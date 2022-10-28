using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioClip audioClip1;
    [SerializeField] AudioClip audioClip2;
    [SerializeField] AudioSource audioSource;
    void Start()
    {
        int rand = Random.Range(0, 2);
        if(rand == 0)
        {
            audioSource.clip = audioClip1;
            audioSource.Play();
            return;
        }
        audioSource.clip = audioClip2;
        audioSource.Play();
    }
}
