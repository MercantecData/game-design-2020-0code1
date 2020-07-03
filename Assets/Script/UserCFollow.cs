using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCFollow : MonoBehaviour
{
    public GameObject player;
  

    // Update is called once per frame
    void Update()
    {
        
        var Playerpos = player.transform.position;

        #region check position
        //print(mousePos);
        //print(mousePosWorld);
        #endregion

        var timeToMousePosition = Playerpos - transform.position;

        transform.up = timeToMousePosition;

    }
}
