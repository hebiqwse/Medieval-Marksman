using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    public bool useGravity = true;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        rb.useGravity = false;
        if(useGravity)
            rb.AddForce(Physics.gravity * (rb.mass *rb.mass));
    }
}
