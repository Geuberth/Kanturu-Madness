using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mueveteputa : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxEffect;
    private Transform cameraTransform;
    private Vector3 LastCameraPosition;
    private float textureUnitSizeX;

    // Start is called before the first frame update
    private void Start()
    {
        cameraTransform = Camera.main.transform;
        LastCameraPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - LastCameraPosition;
        transform.position += new Vector3(deltaMovement.x * parallaxEffect.x, deltaMovement.y * parallaxEffect.y);
        LastCameraPosition = cameraTransform.position;
        if(Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureUnitSizeX){
            float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureUnitSizeX;
            transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y);
        }
    }
}
