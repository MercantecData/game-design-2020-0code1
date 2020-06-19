using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //shoot a bullet
            if (GameController.instance.bullets != 0)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
                rigidbody.velocity = bullet.transform.right * 30;
                GameController.instance.setBullets(GameController.instance.bullets - 1);
            }
        }
    }

    //void OnMouseDown()
    //{
    //    print("click")
    //}
}
