using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pause : MonoBehaviour {

    public GameObject UI;
    public GameObject arrowspawner;

    public string menuName = "MainMenu";
    public string currentScene;


    void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pauseGame();
        }
    }

    public void pauseGame()
    {
        UI.SetActive(!UI.activeSelf);

        if (UI.activeSelf)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            arrowspawner.GetComponent<ArrowShooter>().enabled = false;
        }

        else
        {
            Time.timeScale = 1;
            Cursor.visible = false;
            arrowspawner.GetComponent<ArrowShooter>().enabled = true;

        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentScene);
      score.currentScore = 0;
       
    }

    public void mainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
        
    }
    

}
