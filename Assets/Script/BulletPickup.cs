using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPickup : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameController.instance.setBullets(GameController.instance.bullets + 5);
            Destroy(gameObject);
        }
        
    }
}
