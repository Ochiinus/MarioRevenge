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
            InvokeRepeating("SpawnBalls",1.0f,1.5f);
            print("Il entre");
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

        float planeZ = GameObject.Find("s6_slope").transform.position.z;
        int z = Random.Range(-10, -4);
        Instantiate(balls, new Vector3(67.21f, 9f, z), Quaternion.identity,GameObject.Find("Scene6").transform );
           print(z);

    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (myRigidbody.velocity.y < FallingThreshold)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.path);
        }

    }
}
