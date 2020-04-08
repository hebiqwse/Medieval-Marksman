﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        soundManagerScript.PlaySound("click");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  
    }

    public void quitGame()
    {
        soundManagerScript.PlaySound("click");
        Application.Quit();
        Debug.Log("you have quit"); 
    }
}
