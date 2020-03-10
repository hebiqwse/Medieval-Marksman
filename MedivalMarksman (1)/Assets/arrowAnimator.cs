﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class arrowAnimator : MonoBehaviour
{
    Animator anim;
    Animator cancelanim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("mouse clicked");
            anim.SetTrigger("Active");
            anim.enabled = true;

        }

        else if (Input.GetMouseButtonUp(0))
        {

            Debug.Log("mouse up");
            anim.SetTrigger("Inactive");
            Destroy(anim);

        }
    }
}