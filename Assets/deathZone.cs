using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col){

        float posX = 84;
        float posY = 9;
        float posZ = -16;

        if (col.name == "FirstPersonController")
        {
            col.transform.position = new Vector3(posX, posY, posZ);
        }
    }
}
