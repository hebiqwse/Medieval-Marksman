using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{
    Rigidbody rb;
    public float shootforce = 2000;
  
    void OnEnable()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        applyForce();
        
    }

    void Update()
    {
        spin();
    }

    void applyForce()
    {
        rb.AddRelativeForce(Vector3.forward * shootforce);
      
    }

    void spin()
    {
        float yvelocity = rb.velocity.y;
        float zvelocity = rb.velocity.z;
        float xvelocity = rb.velocity.x;
        float combinedvelocity = Mathf.Sqrt(xvelocity * xvelocity + zvelocity * zvelocity);
        float fallangle = -1* Mathf.Atan2(yvelocity, combinedvelocity) * 180 / Mathf.PI;

        transform.eulerAngles = new Vector3(fallangle, transform.eulerAngles.y, transform.eulerAngles.z);
        
    }
}
