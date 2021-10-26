using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class masseContact : MonoBehaviour
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
        if(col.name == "First Person Controller"){
            col.transform.position = new Vector3(120f, 0f, 72f);
        }
    }
}
