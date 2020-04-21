using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animatorClick : MonoBehaviour
{
    Animator anim;
    //public static AudioClip bowSound;
    //static AudioSource audioSrc;

    void Start()
    {
         anim = gameObject.GetComponent<Animator>();
        //bowSound = Resources.Load<AudioClip>("bowFire");
        //audioSrc = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            Debug.Log("mouse clicked");
            anim.SetTrigger("Active");
            fire();
        }

        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("mouse up");
            anim.SetTrigger("Inactive");
            
         
        }
    }

    public void fire()
    {
        //audioSrc.clip = bowSound;
        //audioSrc.Play();
    }
}
