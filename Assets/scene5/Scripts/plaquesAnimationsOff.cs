using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plaquesAnimationsOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("plaque-1").GetComponent<Animator>().enabled = false;
        GameObject.Find("plaque-2").GetComponent<Animator>().enabled = false;   
        GameObject.Find("plaque-3").GetComponent<Animator>().enabled = false;   
        GameObject.Find("plaque-4").GetComponent<Animator>().enabled = false;   
        GameObject.Find("plaque-5").GetComponent<Animator>().enabled = false;
    }

}
