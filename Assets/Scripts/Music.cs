using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioClip soundClip;
    private AudioSource audioSource;

    private void Start()
    {
        // Create an AudioSource component
        audioSource = gameObject.AddComponent<AudioSource>();

        // Set the audio clip
        audioSource.clip = soundClip;

        // Play the sound
        audioSource.Play();
    }

    private void OnDestroy()
    {
        // Stop the sound
        audioSource.Stop();
    }
}
