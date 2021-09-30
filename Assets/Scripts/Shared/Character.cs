using UnityEngine;

public class Character : MonoBehaviour
{
    protected float currentHealth;
    protected bool Grounded;
    protected bool right;
    protected bool left;
    protected Rigidbody2D rb2d;
    protected SpriteRenderer spriterenderer;
    protected Animator animator;
    protected Collider2D collider;
    [SerializeField] protected float health;
    [SerializeField] protected float runSpeed;
    [SerializeField] protected float Jump;
    [SerializeField] protected Transform groundCheck;
    [SerializeField] protected Transform groundCheckL;
    [SerializeField] protected Transform groundCheckR;
    [SerializeField] protected float Attackrange;
    [SerializeField] protected int AttackDamage = 50;
    [SerializeField] protected Transform AttackPoint;
    [SerializeField] protected LayerMask Layer;

    void Awake()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        collider = this.GetComponent<Collider2D>();
    }
    protected virtual void DoDamage()
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
        if (this.collider.IsTouching(GameObject.Find("Ground").GetComponent<Collider2D>()))
        {
            Grounded = true;
            animator.SetBool("Jumping", false);
        } else
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

    public virtual void TakeDamage(float damage)
    {
        animator.SetTrigger("Hurt");
        if(currentHealth > 0){
            currentHealth -= damage;
        }        
        if (currentHealth <= 0.0f)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        animator.SetBool("Isdead", true);
        this.enabled = false;
    }
}
