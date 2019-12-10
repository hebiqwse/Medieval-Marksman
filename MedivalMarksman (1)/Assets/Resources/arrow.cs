using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public bool inWindZone = false;
    public GameObject windZone;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

  private  void FixedUpdate()
    {
        if (inWindZone)
        {
            rb.AddForce(windZone.GetComponent<windArea>().direction * windZone.GetComponent<windArea>().strength);
        }
    }

    void OnTriggerEnter (Collider collider)
    {
        if (collider.gameObject.tag == "windArea")
        {
            windZone = collider.gameObject;
            inWindZone = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "windArea")
            inWindZone = false;
    }


    
}
