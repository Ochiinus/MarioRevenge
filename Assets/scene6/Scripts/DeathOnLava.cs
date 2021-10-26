using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathOnLava : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "First Person Controller")
        {
            GameObject.Find("First Person Controller").transform.position = new Vector3(49.62f, 14.72f, 52.04f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
