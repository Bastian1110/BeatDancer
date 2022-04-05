using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to make the camera follow the player
public class CameraFollow : MonoBehaviour
{
    public int distancia = 0;
    public Transform followTransform;

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(followTransform.position.x + distancia, this.transform.position.y,this.transform.position.z);
    }
}
