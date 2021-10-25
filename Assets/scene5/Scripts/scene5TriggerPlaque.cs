using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class scene5TriggerPlaque : MonoBehaviour
{

    public GameObject go;

    void OnTriggerEnter(Collider col) {
       

        if (col.name == "First Person Controller")
        {
           go.GetComponent<Animator>().enabled = true;
        }
    }
}
