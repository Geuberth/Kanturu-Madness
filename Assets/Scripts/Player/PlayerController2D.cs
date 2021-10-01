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

    public void OnAttack()
    {
        GetComponent<Animator>().SetTrigger("Attack");
        //DoDamage(CheckEnemies());
    }

    protected void DisableInput()
    {

        GetComponent<PlayerInput>().enabled = false;

    }
}
