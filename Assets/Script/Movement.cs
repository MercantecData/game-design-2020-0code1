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

        /// ude Method !Virker!
        #region  ude method
        position.x += speed * Time.deltaTime * Input.GetAxis("Horizontal");
        position.y += speed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.position = position;
        rigidbody.MovePosition(position);
        #endregion


        Vector3 rotate = transform.eulerAngles;

        ///test for method charAxis
        #region Med method
        //CharAxis(position.x, "Horizontal");
        //CharAxis(position.y, "Vertical");

        #endregion

        /// rotation af object in 2D  we must use z, recommanded on eulerAngles
        /// missing a kind of loop for the mouse event ! 
        #region selvcode virker men ikke god practice
        //if (Input.mousePosition.x > position.x)
        //{
        //    rotate.z = 90;
        //}
        //if (Input.mousePosition.x < position.x)
        //{
        //    rotate.z = 270;
        //}
        //if (Input.mousePosition.y < position.y)
        //{
        //    rotate.z = 0;
        //}
        //if (Input.mousePosition.y > position.y)
        //{
        //    rotate.z = 180;
        //}
        #endregion

        transform.eulerAngles = rotate;

    }

    #region faild experimental method
    //public Vector2 CharAxis(float position, string orientation)
    //{
    //    position += speed * Time.deltaTime * Input.GetAxis(orientation);
    //    transform.position = position;
    //}
    #endregion



}


