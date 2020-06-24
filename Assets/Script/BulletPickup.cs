using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPickup : MonoBehaviour
{
    public AudioClip Clip;

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            GameController.instance.setBullets(GameController.instance.bullets + 5);
            Destroy(gameObject);

            // play even on destroy object. wish instentiat the sound object and destroy it after
            var clip = GetComponentInChildren<AudioSource>().clip;
            AudioSource.PlayClipAtPoint(clip, Vector2.zero);
        }
        
    }
}
