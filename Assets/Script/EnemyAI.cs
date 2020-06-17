using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.Android;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class EnemyAI : MonoBehaviour
{
    private string currentState = "Patrol";
    public float speed = 5;
    private Transform nextwaypoint;
    public Transform waypoint1;
    public Transform waypoint2;
    public Transform player;
    public LayerMask mask;
    public float range = 15;
    private Vector3 currentTarget;
    
    // Start is called before the first frame update
    void Start()
    {
        nextwaypoint = waypoint1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (currentState == "Patrol")
        {
            Vector2 nextposition = Vector2.MoveTowards(transform.position, nextwaypoint.position, Time.deltaTime * speed);

            transform.position = nextposition;

           

            if (transform.position == waypoint1.position || transform.position == waypoint2.position )
            {
                

                if (nextwaypoint == waypoint1)
                {
                    

                    nextwaypoint = waypoint2;
                }
                else
                {
                    nextwaypoint = waypoint1;
                }
            }

            //emile code
            currentTarget = nextwaypoint.position - transform.position;
            transform.up = currentTarget;


            if (targetAquired())
            {
                
                currentState = "Attack";
            }
        }
        else if (currentState == "Attack")
        {
            Vector2 AttakeMove = Vector2.MoveTowards(transform.position, player.position, Time.deltaTime * speed);

            transform.position = AttakeMove;

            var Target = player.transform.position;
            var timeToMousePosition = Target - transform.position;

            transform.up = timeToMousePosition;

            if (!targetAquired())
            {
                currentState = "Patrol";
            }
        }
        

        bool targetAquired()
        {
            GameObject targetGO = GameObject.FindGameObjectWithTag("Player");
            bool inRange = false;
            bool inVision = false;

            if (Vector2.Distance(targetGO.transform.position, transform.position) < range)
            {
                inRange = true;
            }

            var linecast = Physics2D.Linecast(transform.position, targetGO.transform.position, mask);
            if (linecast.transform == null)
            {
                inVision = true;
            }
            return inRange && inVision;

        }
    }
}
