using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_game_object : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
