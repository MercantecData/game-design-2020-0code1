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
            //GameController.instance.setWinCondition("YOU WIN");
            GameController.instance.setEnemyKill(GameController.instance.kills + 1);
        }
        if (other.CompareTag("Environment"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            if (GameController.instance.life != 1)
            {
                GameController.instance.setLife(GameController.instance.life - 1);
                Destroy(gameObject);
            }
            else
            {
                GameController.instance.setLife(GameController.instance.life - 1);
                Destroy(other.gameObject);
                Destroy(gameObject);
                GameController.instance.setWinCondition("YOU LOSE");
            }
           
        }
    }
}
