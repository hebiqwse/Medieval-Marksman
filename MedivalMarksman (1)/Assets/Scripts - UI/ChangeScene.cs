using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public static AudioClip clickSound;
    static AudioSource audioSrc;

    public void Start()
    {
        clickSound = Resources.Load<AudioClip>("click");
        audioSrc = GetComponent<AudioSource>();
    }
    public void startGame()
    {
        SceneManager.LoadScene("Tutorial");
        ScoreCounterText.itemAmount = 0;
        click();
    }

    public void levelTwo()
    {
        SceneManager.LoadScene("Level 2");
        ScoreCounterText.itemAmount = 0;
        click();
    }

    public void levelThree()
    {
        SceneManager.LoadScene("Level 3");
        ScoreCounterText.itemAmount = 0;
        click();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        ScoreCounterText.itemAmount = 0;
        click();
    }

    //Added by Freya Smith
    public void levelClear()
    {
        SceneManager.LoadScene("LevelClear");
        ScoreCounterText.itemAmount = 0;
        click();
    }

    public void click()
    {
       
        audioSrc.clip = clickSound;
        audioSrc.Play();
    }
}
