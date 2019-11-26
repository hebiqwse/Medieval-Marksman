using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour
{
    [SerializeField]
    Transform[] waypoints;
    int currentWaypoint;
    Rigidbody RB;
    [SerializeField]
    float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
    }

    void Movement()
    {
        if(Vector3.Distance(transform.position, waypoints[currentWaypoint].position) < .25f)
        {
            currentWaypoint += 1;
            currentWaypoint = currentWaypoint % waypoints.Length;
        }

        Vector3 _dir = (waypoints[currentWaypoint].position - transform.position).normalized;
        RB.MovePosition(transform.position + _dir * moveSpeed * Time.deltaTime);
    }
}
