using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    
    //it can be buggy if the camera is on the player
    public Transform cameraPos;

    private void Update()
    {
        transform.position = cameraPos.position;
    }
}
