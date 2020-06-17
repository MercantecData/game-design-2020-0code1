using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 1);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Destroy(this);
        if (other.tag != "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
    }
}
