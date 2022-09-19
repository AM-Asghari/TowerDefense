using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTarget : MonoBehaviour
{
    private Waypoints Wpoints;
    private int waypointIndex;

    public Transform target;
    public float t;


    // Start is called before the first frame update
    void Start()
    {
        Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 a = transform.position;
        Vector2 b = Wpoints.waypoints[waypointIndex].position;
        transform.position = Vector2.Lerp(a, b, t * Time.deltaTime);

        if(Vector2.Distance(a, b) < 0.1f)
        {
            if(waypointIndex < Wpoints.waypoints.Length - 1)
            {
                waypointIndex++;
            }
        }
    }
}
