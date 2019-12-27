using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timerBar : MonoBehaviour
{
    Image timeBarScript;
    public float maxTime = 5f;
    private float gameTimer;
    private bool gamePaused = false;
    float timeLeft;

    public Text countdown;
  
 
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        int buildIndex = currentScene.buildIndex;

        if (buildIndex == 1 || buildIndex == 2)
        Time.timeScale = 1;
        timeBarScript = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()

    {

        countdown.text = ("" + (int)timeLeft);

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
         //   timeBarScript.fillAmount = timeLeft / maxTime;
        }
        else
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("GameOver");
            Destroy(this);
            Time.timeScale = 1;
            
        }
    }

   
}
