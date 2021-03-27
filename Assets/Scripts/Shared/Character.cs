using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] protected float health;
    protected float currentHealth;
    protected bool Grounded;
    protected bool right;
    protected bool left;
    protected Rigidbody2D rb2d;
    protected SpriteRenderer spriterenderer;
    [SerializeField] protected float runSpeed;
    [SerializeField] protected float Jump;
    [SerializeField] protected Transform groundCheck;
    [SerializeField] protected Transform groundCheckL;
    [SerializeField] protected Transform groundCheckR;
    [SerializeField] protected float Attackrange;
    [SerializeField] protected int AttackDamage = 50;
    protected Transform AttackPoint;
    protected Animator animator;
    protected LayerMask Layer;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
    }
    protected void DoDamage()
    {
        Collider2D[] HitTargets = Physics2D.OverlapCircleAll(AttackPoint.position, Attackrange, Layer);
        foreach (Collider2D character in HitTargets)
        {
            if (character.enabled)
            {
                character.GetComponent<Character>().TakeDamage(AttackDamage);
            }
        }
    }
    protected void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;
        Gizmos.DrawWireSphere(AttackPoint.position, Attackrange);
    }

    protected void CheckGround()
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

    protected void CheckMove()
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

    public virtual void TakeDamage(int damage)
    {
        animator.SetTrigger("Hurt");
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        animator.SetBool("Isdead", true);
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
