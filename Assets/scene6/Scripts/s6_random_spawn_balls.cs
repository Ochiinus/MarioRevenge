using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s6_random_spawn_balls : MonoBehaviour
{

    public GameObject balls;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnBalls",1.0f,2.0f);
    }

    void SpawnBalls()
    {

        float planeZ = GameObject.Find("s6_slope").transform.position.z;
        balls = GameObject.FindGameObjectWithTag("s6_death_balls");
        float z = Random.Range(-2f,-10f);
        Instantiate(balls, new Vector3(91.92f, 20.71f, planeZ), Quaternion.identity,GameObject.Find("Scene6").transform );
        print(z);
        print(GameObject.Find("s6_slope").transform.position);
           

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
