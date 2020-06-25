using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    
   // private AudioSource audioSource;

    private void Start()
    {
        // fo fat i children object  med en AudioSource
        //audioSource = GetComponentInChildren<AudioSource>();

    }

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
                #region  school example for 3D lyde 
                //var clip = GetComponentInChildren<AudioSource>().clip;
                //AudioSource.PlayClipAtPoint(audioSource.clip, Vector2.zero);
                #endregion
                //SoundController test = new SoundController();
                //test.startShoot();

                SoundController.instance.startShoot();
            }
        }
    }

    //void OnMouseDown()
    //{
    //    print("click")
    //}
}
