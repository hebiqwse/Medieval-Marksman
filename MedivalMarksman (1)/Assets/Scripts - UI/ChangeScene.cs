using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Tutorial");
        ScoreCounterText.itemAmount = 0;
    }

    public void levelTwo()
    {
        SceneManager.LoadScene("Level 2");
        ScoreCounterText.itemAmount = 0;
    }

    public void levelThree()
    {
        SceneManager.LoadScene("Level 3");
        ScoreCounterText.itemAmount = 0;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
        ScoreCounterText.itemAmount = 0;
    }
}
