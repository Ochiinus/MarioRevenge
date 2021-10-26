using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZoneScene3 : MonoBehaviour
{
    void OnTriggerEnter(Collider col){

       // float posX = 4;
        //float posY = 1;
        //float posZ = 1;


        if (col.name == "First Person Controller")
        {
            col.transform.position = GameObject.Find("checkPointScene3").transform.position;
        }
    }
}
