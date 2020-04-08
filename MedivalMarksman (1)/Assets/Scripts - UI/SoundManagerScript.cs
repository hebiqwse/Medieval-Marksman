using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    //Initialise Sound variables
    public static AudioClip cheerSound, clickSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        //Loads sound values to the variables
        cheerSound = Resources.Load<AudioClip>("cheer");
        clickSound = Resources.Load<AudioClip>("click");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "cheer":
                audioSrc.PlayOneShot(cheerSound);
                break;
            case "click":
                audioSrc.PlayOneShot(clickSound);
                break;
        }
    }

}
