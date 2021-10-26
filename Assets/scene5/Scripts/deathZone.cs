using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col){

        float posX = 89;
        float posY = 10;
        float posZ = -17;

        if (col.name == "First Person Controller")
        {
            col.transform.position = new Vector3(posX, posY, posZ);
        }
    }
}
