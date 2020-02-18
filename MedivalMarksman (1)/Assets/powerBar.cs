using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//https://answers.unity.com/questions/1269020/can-i-use-imagefillamount-to-fill-a-power-bar-with.html


public class powerBar : MonoBehaviour
{
    public Image powerbarScript;
    [SerializeField]
    private float percentage;
    public float sign;
    [SerializeField]
    private float currentamount;
    bool buttonpressed = false;

    
    void Start()
    {
        if (powerbarScript != null)
        {
            percentage = powerbarScript.fillAmount * 100;
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            percentage += sign;
            

            if (percentage >= 100 || percentage <= 0)
            {
                sign *= -1;
                percentage = ((percentage <= 0) ? 0 : 100);

            }
        }
        if (powerbarScript != null)
        {
            powerbarScript.fillAmount = percentage / 100;
        }
        
        if (Input.GetMouseButtonUp(0))
        {
            percentage = 0;
        }
    }
}
