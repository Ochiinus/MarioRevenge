using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void OnTriggerEnter(Collider col){


        if (col.name == "First Person Controller")
        {
            float planeX = GameObject.Find("marche-1").transform.position.x;
            float planeY = GameObject.Find("marche-1").transform.position.y;
            float planeZ = GameObject.Find("marche-1").transform.position.z;
            GameObject.Find("First Person Controller").transform.position = new Vector3(planeX, planeY, planeZ);        }
    }
}
