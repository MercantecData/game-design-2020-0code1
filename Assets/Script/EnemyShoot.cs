using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform player;
    public GameObject enemy;
    
    #region property for update version
    //private float nextActionTime = 0.3f;
    //public float period = 0.0f;
    // Start is called before the first frame update
    #endregion
    void Start()
    {
        InvokeRepeating("Shoot", 0.1f, 1);
    }


    // update version virker, men bruger af start er mere bespare for performance da vores invoker har en repeat på 0,6sec.
    #region Solution med Update
    // Update is called once per frame
    //void Update()
    //{
    //    if (Time.time > nextActionTime)
    //    {
    //        nextActionTime += period;
    //        if (Vector2.Distance(player.transform.position, transform.position) < 10f)
    //        {
    //            Shoot();
    //        }
    //    }
    //}

    #endregion

    void Shoot()
    {
        if (Vector2.Distance(player.transform.position, transform.position) < 10f)
        {
            enemy.GetComponent<Animator>().SetBool("Enemy.Shoot", true);
            StartCoroutine(Bullet(0.1f));
            
        }
        
    }

    IEnumerator Bullet(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.velocity = bullet.transform.right * 30;
        SoundController.instance.startShoot();
    }
}
