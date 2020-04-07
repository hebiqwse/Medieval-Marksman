using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooter : MonoBehaviour
{
    private GameObject arrowPrefab;
    // Start is called before the first frame update
    void Start()
    {
        arrowPrefab = Resources.Load("Arrow") as GameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newArrow = Instantiate(arrowPrefab) as GameObject;
            newArrow.transform.position = transform.position;
            Rigidbody rb = newArrow.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 30;
=======
        shootLogic();

    }
    void spawnArrow()
        {
            if (numofArrows> 0)
            {
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
                Destroy(arrow.GetComponent<Animator>());
              
                _arrowproject.shootforce = _arrowproject.shootforce * ((pulldown/100) +1f);
                 numofArrows -= 1;
                pulldown = 0;
                 _arrowproject.enabled = true;

                if (numofArrows == 0)
                {
                    SceneManager.LoadScene("GameOver");
                }

            }
           

            if (Input.GetMouseButtonDown(0) && arrowSlotted == false)
                spawnArrow();
            
>>>>>>> Stashed changes
        }
        
    }
}
