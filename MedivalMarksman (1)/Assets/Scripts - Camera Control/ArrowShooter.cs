using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ArrowShooter : MonoBehaviour
{
    [SerializeField]
    int numofArrows = 10;
    bool arrowSlotted = false;
    [SerializeField]
    GameObject arrow;
    [SerializeField]
    GameObject arrowPrefab;
    public float speed;

    public float pulldown;
    public float pullspeed;
    // Start is called before the first frame update
    void Start()
    {

        spawnArrow();
    }

    // Update is called once per frame
    void Update()
    {
        shootLogic();

    }
    void spawnArrow()
        {
            if (numofArrows> 0)
            {
            Transform camT = Camera.main.transform;
                arrowSlotted = true;
                arrow = Instantiate(arrowPrefab,transform.position, transform.rotation) as GameObject;
                arrow.transform.parent = transform;
                
            }
        }
    void shootLogic()
    {
        if (numofArrows > 0)
        {
      

            Rigidbody arrowrb = arrow.transform.GetComponent<Rigidbody>();
            addforce _arrowproject = arrow.transform.GetComponent<addforce>();

            if (Input.GetMouseButton(0))
            {

             
                pulldown += Time.deltaTime * pullspeed;
                
                if (pulldown >= 6000 || pulldown <= 0)
                {
                    pullspeed *= -1;
                }
  
                  
                Debug.Log(pulldown);
            }

            if (Input.GetMouseButtonUp(0))
            {
              //  GameObject newArrow = Instantiate(arrowPrefab) as GameObject;
             //   newArrow.transform.position = transform.position;
               // Rigidbody rb = newArrow.GetComponent<Rigidbody>();
              //  arrowrb.velocity = Camera.main.transform.forward * speed;
                
                
                
                arrowSlotted = false;
                arrowrb.isKinematic = false;
                arrow.transform.parent = null;
               
                _arrowproject.shootforce = _arrowproject.shootforce * ((pulldown/100) +1f);
                 numofArrows -= 1;
                pulldown = 0;
                 _arrowproject.enabled = true;

                if (numofArrows <= 0)
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
           

            if (Input.GetMouseButtonDown(0) && arrowSlotted == false)
                spawnArrow();
            
        }
    }
}
