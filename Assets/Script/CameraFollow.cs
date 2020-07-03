using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        var playerposition = player.position;
        playerposition = transform.position;
        transform.position = playerposition;
    }
}
