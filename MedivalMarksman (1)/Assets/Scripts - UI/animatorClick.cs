using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animatorClick : MonoBehaviour
{
    Animator anim;
    
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();    
    }
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            Debug.Log("mouse clicked");
            anim.SetTrigger("Active");
           
        }
    }
}
