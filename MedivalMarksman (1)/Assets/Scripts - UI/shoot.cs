using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{


    [SerializeField]
    float pullSpeed;
    [SerializeField]
    GameObject arrowPrefab;
    [SerializeField]
    GameObject arrow;
    [SerializeField]
    int numofArrows = 10;
    [SerializeField]
    GameObject bow;
    [SerializeField]
    GameObject bowTopEnd;
    static Vector3 originalPos;
    bool arrowslotted = false;
    float pullamount = 0;


    void Start()
    {
        
        originalPos = new Vector3(bow.transform.position.x, bow.transform.position.y, bow.transform.position.z);
        Debug.Log(originalPos);
      
        //  spawnArrow();

    }

    // Update is called once per frame
    void Update()
    {
        shootLogic();
      
    }

   /* void spawnArrow()
    {
        if (numofArrows >0)
        {
            arrowslotted = true;
            arrow = Instantiate(arrowPrefab, transform.position, transform.rotation) as GameObject;
            arrow.transform.parent = transform;
        }
    }*/

    void shootLogic()
    {
        if (numofArrows > 0)
        {
           
            if (Input.GetMouseButton(0))
            {
               
                pullamount += Time.deltaTime * pullSpeed;
                bow.transform.Translate(0, -pullamount, 0);

                
            }

            if (Input.GetMouseButtonUp(0))
            {
                bow.transform.position = originalPos;
                pullamount = 0;
                Debug.Log(bow.transform.position);
            }
        }
    }

   
}
