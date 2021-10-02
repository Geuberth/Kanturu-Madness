using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public const string PLAYER = "Kargaros";
    private Transform playerTransform;
    private double horizontal;
    private double vertical;
    // Start is called before the first frame update
    void Start() {
        playerTransform = GameObject.FindGameObjectWithTag(PLAYER).transform;
        vertical = Camera.main.orthographicSize;
        horizontal = vertical * Screen.width / Screen.height;
    }

    // Update is called once per frame
    void LateUpdate() {
        if (this.gameObject.transform.position.x + horizontal >= GameObject.FindWithTag("Scene_change").transform.position.x) {
            if (GameObject.FindWithTag(PLAYER).transform.position.x < this.transform.position.x) {
                cameraMove();
            }
        }
        else {
            cameraMove();
        }

    }
    private void cameraMove(){
        // we store the current camera's position in var temp 
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        //temp.y = playerTransform.position.y;
        // we set the camera's temp position to the camera's current position
        transform.position = temp;
    }
}
