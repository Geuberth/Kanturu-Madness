using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    private bool Grounded;
    private bool right;
    private bool left;
    Rigidbody2D rb2d;
    SpriteRenderer spriterenderer;
    [SerializeField]
    private float runSpeed;
    [SerializeField]
    private float Jump;
    [SerializeField]
    Transform groundCheck;
    [SerializeField]
    Transform groundCheckL;
    [SerializeField]
    Transform groundCheckR;


    public Animator animator;
    public Health_Bar healthBar;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
    }


    private void FixedUpdate()
    {
        CheckGround();

        CheckMove();

    }

    #region "INPUTS"
    public void OnJump()
    {
        if (Grounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, Jump);
        }
    }

    public void OnMoveLeft()
    {
        left = !left;
    }

    public void OnMoveRight()
    {
        right = !right;
    }

    public void OnAttack()
    {
        animator.SetTrigger("Attack");
    }

    public void OnAttack2()
    {
        animator.SetTrigger("Attack2");
    }

    #endregion "INPUTS"

    #region "RESUME"
    private void CheckGround()
    {
        if ((Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"))) ||
            (Physics2D.Linecast(transform.position, groundCheckR.position, 1 << LayerMask.NameToLayer("Ground"))) ||
            (Physics2D.Linecast(transform.position, groundCheckL.position, 1 << LayerMask.NameToLayer("Ground"))))
        {
            Grounded = true;
            animator.SetBool("Jumping", false);
        }
        else
        {
            Grounded = false;
            animator.SetBool("Jumping", true);
        }
    }

    private void CheckMove()
    {
        if (left || right)
        {
            animator.SetBool("Speed", true);
            if (left)
            {
                spriterenderer.flipX = true;
                rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);
            }
            else if (right)
            {
                spriterenderer.flipX = false;
                rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y);
            }
        }
        else
        {
            animator.SetBool("Speed", false);
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }
    }
    #endregion "RESUME"
}
