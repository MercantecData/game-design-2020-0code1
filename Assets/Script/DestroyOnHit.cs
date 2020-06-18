using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 1);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(this);
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameController.instance.setWinCondition("YOU WIN");

        }
        if (other.CompareTag("Environment"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameController.instance.setWinCondition("YOU LOSE");
        }
    }
}
