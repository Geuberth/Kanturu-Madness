using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum Move
    {
        Left,
        Right,
        Stand,
    }

    public const string ENEMIES_LAYER = "Enemies";

    protected float currentHealth;
    protected bool grounded;
    protected Move movement = Move.Stand;

    protected Dictionary<string, GameObject> children;

    [SerializeField] protected float health;
    [SerializeField] protected float runSpeed;
    [SerializeField] protected float jump;
    [SerializeField] protected float attackRange;
    [SerializeField] protected int attackDamage;

    private void Awake()
    {
        children = new Dictionary<string, GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform obj = transform.GetChild(i);
            children.Add(obj.name, obj.gameObject);
        }
    }

    protected void FixedUpdate()
    {
        CheckGround();
        CheckMove();
    }
    protected virtual Collider2D[] CheckEnemies()
    {
        Collider2D[] targetsHitted = Physics2D.OverlapCircleAll(children["AttackPoint"].transform.position, attackRange, LayerMask.GetMask(ENEMIES_LAYER));
        return targetsHitted;
    }

    protected virtual void DoDamage(Collider2D[] enemies)
    {
        if (enemies.Length > 0)
        {
            foreach (Collider2D enemy in enemies)
            {
                // if the target is enabled and target is different than this instance then make it take damage.
                if (enemy.enabled && enemy.gameObject != gameObject)
                {
                    enemy.gameObject.GetComponent<Character>().TakeDamage(attackDamage);
                }
            }
        }
    }

    protected void CheckGround()
    {
        grounded = GetComponent<Collider2D>().IsTouching(GameObject.Find("Ground").GetComponent<Collider2D>());
        GetComponent<Animator>().SetBool("Jumping", !grounded);
    }

    #region "Character Movement"
    protected void Movement()
    {
        GetComponent<Animator>().SetBool("Speed", true);
    }


    protected void Stand()
    {
        GetComponent<Animator>().SetBool("Speed", false);
        movement = Move.Stand;
    }

    protected void CheckMove()
    {
        switch (movement)
        {
            case Move.Left:
                GetComponent<Rigidbody2D>().velocity = new Vector2(-runSpeed, GetComponent<Rigidbody2D>().velocity.y);
                break;
            case Move.Right:
                GetComponent<Rigidbody2D>().velocity = new Vector2(runSpeed, GetComponent<Rigidbody2D>().velocity.y);
                break;
            default:
                Stand();
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, GetComponent<Rigidbody2D>().velocity.y);
                break;
        }
    }

    public void OnJump()
    {
        if (grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
        }
    }

    public void OnMoveLeft()
    {
        Movement();
        GetComponent<SpriteRenderer>().flipX = true;
        movement = Move.Left;
    }

    public void OnMoveRight()
    {
        Movement();
        GetComponent<SpriteRenderer>().flipX = false;
        movement = Move.Right;
    }

    public void OnMoveLeftStop()
    {
        if (movement == Move.Right) { }
        else
        {
            Stand();
        }

    }

    public void OnMoveRightStop()
    {
        if (movement == Move.Left) { }
        else
        {
            Stand();
        }
    }
    #endregion "Character Movement"

    #region "Attack"
    public void OnAttack()
    {
        GetComponent<Animator>().SetTrigger("Attack");
        //DoDamage(CheckEnemies());
    }

    public virtual void TakeDamage(float damage)
    {
        GetComponent<Animator>().SetTrigger("Hurt");
        if (currentHealth > 0)
        {
            currentHealth -= damage;
        }
        if (currentHealth <= 0.0f)
        {
            Die();
        }
    }
    #endregion "Attack"

    protected virtual void Die()
    {
        GetComponent<Animator>().SetBool("Isdead", true);
        enabled = false;
    }
}
