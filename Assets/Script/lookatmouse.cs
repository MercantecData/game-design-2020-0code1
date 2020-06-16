using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatmouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        var mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);

        #region check position
        //print(mousePos);
        //print(mousePosWorld);
        #endregion

        var timeToMousePosition = mousePosWorld - transform.position;
        timeToMousePosition.z  = 0;

        transform.right = timeToMousePosition;
    }
}
