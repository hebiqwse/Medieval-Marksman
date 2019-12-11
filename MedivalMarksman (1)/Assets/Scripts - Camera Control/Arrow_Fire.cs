using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Fire : MonoBehaviour
{
    Rigidbody rb;
    public bool hitSomething;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (!hitSomething)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
           
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

    public void stick()
    {
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}

