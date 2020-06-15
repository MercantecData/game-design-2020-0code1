using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 10;
    private new Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /// The Vector2 is for 2d
        Vector2 position = transform.position;
        position.x += speed * Time.deltaTime * Input.GetAxis("Horizontal");
        position.y += speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.position = position;
        rigidbody.MovePosition(position);

        /// rotation af object in 2D  we must use z, recommanded on eulerAngles
        /// missing a kind of loop for the mouse event ! 
        Vector3 rotate = transform.eulerAngles;

        #region selvcode
        if (Input.mousePosition.x > position.x)
        {
            rotate.z = 90;
        }
        if (Input.mousePosition.x < position.x)
        {
            rotate.z = 270;
        }
        if (Input.mousePosition.y < position.y)
        {
            rotate.z = 0;
        }
        if (Input.mousePosition.y > position.y)
        {
            rotate.z = 180;
        }
        #endregion

        transform.eulerAngles = rotate;

    }


}
