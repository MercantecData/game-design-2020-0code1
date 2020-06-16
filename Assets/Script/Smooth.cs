using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smooth : MonoBehaviour
{
    public Transform player;
    private Vector3 veolicty;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var playerPosition = player.position;
        playerPosition.z = transform.position.z;

        var target = Vector3.SmoothDamp(transform.position, playerPosition, ref veolicty, 0.5f);
        transform.position = target;
    }
}
