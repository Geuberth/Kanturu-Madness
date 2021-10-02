using UnityEngine;
using UnityEngine.InputSystem;

public class KargarosController : Character
{
    public Energy_Bar energyBar;
    public Health_Bar healthBar;
    private float energy;
    private float currentEnergy;

    void Start()
    {
        //currentHealth = health;
        //healthBar.FillBar();
        //energyBar.FillBar();
    }

    protected void DisableInput()
    {

        GetComponent<PlayerInput>().enabled = false;

    }
}
