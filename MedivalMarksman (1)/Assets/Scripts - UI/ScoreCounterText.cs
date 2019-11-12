using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounterText : MonoBehaviour
{
    Text text;
    public static int itemAmount;

    void Start()
    {
        
       
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = itemAmount.ToString();
    }
}
