using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;



public class OnTrigger : MonoBehaviour
{
    public GameObject balls;
    public Rigidbody myRigidbody;
    public float FallingThreshold = -10f;
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "First Person Controller")
        {
            InvokeRepeating("SpawnBalls",0f,1.5f);
        }
    }
    
    private void OnTriggerExit(Collider col)
    {
        if (col.name == "First Person Controller")
        {
            CancelInvoke("SpawnBalls");
        }
    }
    
    void SpawnBalls()
    {

        float planeX = GameObject.Find("spawnBalls").transform.position.x;
        float planeY = GameObject.Find("spawnBalls").transform.position.y;
        float planeZ = GameObject.Find("spawnBalls").transform.position.z;
        int z = Random.Range(-8, 0);
        Instantiate(balls, new Vector3(planeX, planeY, planeZ+z), Quaternion.identity,GameObject.Find("Scene6").transform );

    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // if (myRigidbody.velocity.y < FallingThreshold)
        // {
        //     Scene scene = SceneManager.GetActiveScene();
        //     SceneManager.LoadScene(scene.path);
        // }

    }
}
