using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col){


        if (col.name == "First Person Controller")
        {
            float planeX = GameObject.Find("marche-6").transform.position.x;
            float planeY = GameObject.Find("marche-6").transform.position.y;
            float planeZ = GameObject.Find("marche-6").transform.position.z;
            GameObject.Find("First Person Controller").transform.position = new Vector3(planeX, planeY, planeZ);
        }
    }
}
