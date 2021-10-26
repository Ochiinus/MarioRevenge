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
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
