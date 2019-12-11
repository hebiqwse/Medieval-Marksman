using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windArea : MonoBehaviour
{
    public float strength;
    public Vector3 direction;


    private void Start()
    {
       direction = new Vector3(Random.Range(-5, 5), Random.Range(0, 1), Random.Range(0, 1));
       strength = Random.Range(1, 12);
    }
}
