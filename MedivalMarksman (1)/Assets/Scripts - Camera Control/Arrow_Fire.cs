﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Fire : MonoBehaviour
{
    Rigidbody rb;
    public bool hitSomething;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!hitSomething)
        {
      // transform.rotation = Quaternion.LookRotation(rb.velocity);
           
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "arrow")
        {
        
                hitSomething = true;
                stick();

        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "head") || (other.tag == "torso"))
        {
            hitSomething = true;
            rb.transform.SetParent(other.transform.parent);
            stick();
        }

        if ((other.tag == "head2") || (other.tag == "torso2"))
        {
            hitSomething = true;
            rb.transform.SetParent(other.transform.parent);
            stick();
        }
    }

    public void stick()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
        
      
    }
}

