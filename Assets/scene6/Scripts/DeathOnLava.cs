using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathOnLava : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
        if (col.name == "ThirdPersonController")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.path);
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
