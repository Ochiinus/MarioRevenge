using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col){


        if (col.name == "First Person Controller")
        {
            GameObject.Find("First Person Controller").transform.position = new Vector3(49.62f, 14.72f, 52.04f);
        }
    }
}
