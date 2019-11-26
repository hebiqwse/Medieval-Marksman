﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Fire : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.velocity);
        
    }
}