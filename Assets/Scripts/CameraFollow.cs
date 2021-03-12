using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start() {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    // Update is called once per frame
    void LateUpdate() {
        
        // we store the current camera's position in var temp  
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        //temp.y = playerTransform.position.y;
        // we set the camera's temp position to the camera's current position
        transform.position = temp;
    }
}
