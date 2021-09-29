using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2D : Character
{
    public Energy_Bar energyBar;
    public Health_Bar healthBar;
    private float energy;
    private float currentEnergy;

    void Start()
    {
        currentHealth = health;
        healthBar.FillBar();
        energyBar.FillBar();
    }


    private void FixedUpdate()
    {
        CheckGround();

        CheckMove();

        healthBar.TakeDamage(health, currentHealth);
        energyBar.TakeEnergy(energy, currentEnergy);

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
        DoDamage();
    }

    public void OnAttack2()
    {
        animator.SetTrigger("Attack2");
        DoDamage();
    }

    #endregion "INPUTS"

    protected void DisableInput()
    {

        GetComponent<PlayerInput>().enabled = false;

    }
}
