using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{   
    public static AudioClip clickSound;
    static AudioSource audioSrc;

    public void PlayGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        click();
    }

    public void quitGame()
    {
        
        Application.Quit();
        Debug.Log("you have quit");
        click();
    }

    public void click() 
    {
        clickSound = Resources.Load<AudioClip>("click");
        audioSrc.clip = clickSound;
        audioSrc.Play();
    }
}
