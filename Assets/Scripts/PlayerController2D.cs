using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour {

    public Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriterenderer;


    //float x;
    //float y = -0.2f;
    //public GameObject player;
    //bool peguelo = false; 
    //bool holdD = false;
    //bool holdA = false;

    bool Grounded;
    float horizontalMove = 0f; 

    [SerializeField]
    float runSpeed = 10;

    [SerializeField]
    float Jump = 5;

    [SerializeField]
    Transform groundCheck;
    [SerializeField]
    Transform groundCheckL;
    [SerializeField]
    Transform groundCheckR;

    // Start is called before the first frame update
    void Start() {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        //pos = player.transform.position;

    }

    // Update is called once per frame
    //void Update()
    //{

    //if (Input.GetKeyDown(KeyCode.D))
    //{
    //    holdD = true;
    //}
    //if (Input.GetKeyUp(KeyCode.D))
    //{
    //    holdD = false;
    //}
    //if (holdD)
    //{
    //    x = player.transform.position.x;
    //    x += 0.2f;
    //    pos = new Vector3(x, player.transform.position.y, 0);
    //    player.transform.position = pos;
    //}

    //if (Input.GetKeyDown(KeyCode.A))
    //{
    //    holdA = true;
    //}
    //if (Input.GetKeyUp(KeyCode.A))
    //{
    //    holdA = false;
    //}
    //if (holdA)
    //{
    //    x = player.transform.position.x;
    //    x -= 0.2f;
    //    pos = new Vector3(x, player.transform.position.y, 0);
    //    player.transform.position = pos;
    //}

    //if (Input.GetKeyDown(KeyCode.A))
    //{
    //    x = player.transform.position.x;
    //    x -= 1;
    //    pos = new Vector3(x, player.transform.position.y, 0);
    //    player.transform.position = pos;
    //}
    //}

    private void FixedUpdate() {


        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if ((Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"))) ||
            (Physics2D.Linecast(transform.position, groundCheckR.position, 1 << LayerMask.NameToLayer("Ground"))) ||
            (Physics2D.Linecast(transform.position, groundCheckL.position, 1 << LayerMask.NameToLayer("Ground"))))
        {
            Grounded = true;
        }
        else {
            Grounded = false;
        }


        if (Input.GetKey("d") || Input.GetKey("right")) {
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
            if (Grounded)
                animator.Play("Player_run");
                animator.SetBool("Jumping", false);
            spriterenderer.flipX = false;
        }
        else if (Input.GetKey("a") || Input.GetKey("left")) {
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            if (Grounded && rb2d.velocity.y < 0)
                animator.Play("Player_run");
                animator.SetBool("Jumping", false);
            spriterenderer.flipX = true;
        }
        else {
            if (Grounded && rb2d.velocity.y < 0)
                animator.Play("Player_idle");
                animator.SetBool("Jumping", false);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
        if (Input.GetKey("space") && Grounded) {
            rb2d.velocity = new Vector2(rb2d.velocity.x, Jump);
            animator.SetBool("Jumping", true);
            animator.Play("Player_jump");
            
        }
    }
}
