using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject buttonUI;
    //private AudioClip Clip;

    public void OnDisable()
    {
        var clip = GetComponentInChildren<AudioSource>().clip;
        AudioSource.PlayClipAtPoint(clip, Vector2.zero);
        buttonUI.SetActive(false);
    }
}
