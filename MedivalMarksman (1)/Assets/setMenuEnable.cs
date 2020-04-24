using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setMenuEnable : MonoBehaviour
{
    bool menuEnabled = false;
    public GameObject mainmenu;

    void Start()
    {
        menuEnabled = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menuEnabled == true)
        {
            gameObject.SetActive(false);
            mainmenu.SetActive(true);

        }
        
    }
        
    
}
