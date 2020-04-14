using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scorePoints : MonoBehaviour
{
    GameObject head;
    GameObject body;

    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "head")
        {
            score.currentScore += 10;
            ScoreCheck();
        }

        if (collider.tag == "torso")
        {
            score.currentScore += 5;
            ScoreCheck();
        }

        if (collider.tag == "head2")
        {
            score.currentScore += 15;
            ScoreCheck();
        }

        if (collider.tag == "torso2")
        {
            score.currentScore += 30;
            ScoreCheck();
        }

        if (collider.tag == "AnimalHead")
        {
            score.currentScore -= 30;
            ScoreCheck();
        }

        if (collider.tag == "AnimalTorso")
        {
            score.currentScore -= 15;
            ScoreCheck();
        }
    }

    void ScoreCheck()
    {
        if (score.currentScore >= 100)
        {
           //If the score is higher thant 100, load the level clear screen
           SceneManager.LoadScene("LevelClear");
            resetScore();
        }
    }

    void resetScore()
    {
        score.currentScore = 0;
    }
}
