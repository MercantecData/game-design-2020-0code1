using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;

    [SerializeField]
    private AudioClip shoot;
    [SerializeField]
    private AudioClip pickup;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void startShoot()
    {
        audioSource.clip = shoot;
        audioSource.Play();
    }
    public void Pickup()
    {
        audioSource.clip = pickup;
        audioSource.Play();
    }

}
