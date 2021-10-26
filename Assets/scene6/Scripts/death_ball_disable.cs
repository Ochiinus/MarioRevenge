using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death_ball_disable : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 7);

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "First Person Controller")
        {
            float planeX = GameObject.Find("marche-1").transform.position.x;
            float planeY = GameObject.Find("marche-1").transform.position.y;
            float planeZ = GameObject.Find("marche-1").transform.position.z;
            GameObject.Find("First Person Controller").transform.position = new Vector3(planeX, planeY, planeZ);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
