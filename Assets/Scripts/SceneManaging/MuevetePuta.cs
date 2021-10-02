using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevetePuta : MonoBehaviour
{
    [SerializeField] private Vector2 ParallaxEffect;
    [SerializeField] private Transform cameraTransform;
    private Vector3 LastCameraPosition;
    // Start is called before the first frame update
    void Start()
    {
        //cameraTransform = Camera.main.transform;
        LastCameraPosition = transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - LastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * ParallaxEffect.x, deltaMovement.y * ParallaxEffect.y); 
        LastCameraPosition = cameraTransform.position; 
        
    }
}
