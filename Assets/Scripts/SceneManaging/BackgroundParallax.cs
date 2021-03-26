using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public BoxCollider2D Collider;
    public Rigidbody2D rb2d;
    private float width; 
    private float scrollspeed = -2f;

    // Start is called before the first frame update
    void Start()
    {
        Collider = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        width = Collider.size.x;
        Collider.enabled = false;
        rb2d.velocity = new Vector2(scrollspeed, 0);
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
