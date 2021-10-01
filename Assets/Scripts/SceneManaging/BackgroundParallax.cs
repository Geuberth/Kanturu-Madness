using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public BoxCollider2D Collider;
    private float width; 
    private float scrollspeed = -2f;

    // Start is called before the first frame update
    void Start()
    {
        
        width = GetComponent<BoxCollider2D>().size.x;
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().velocity = new Vector2(scrollspeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-width){

            Vector2 resetPosition = new Vector2(width * 2f, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
