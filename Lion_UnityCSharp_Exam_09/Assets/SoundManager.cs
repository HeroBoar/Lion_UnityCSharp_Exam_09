using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    private AudioSource aud;

    public AudioClip sound;

    private void Start()
    {
        aud = GetComponent<AudioSource>();
    }
}
