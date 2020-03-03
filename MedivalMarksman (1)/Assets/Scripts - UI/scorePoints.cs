using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    void ScoreCheck()
    {
        if (score.currentScore >= 100)
        {
           //Does not work
           //ChangeScene.levelClear();
        }
    }
}
