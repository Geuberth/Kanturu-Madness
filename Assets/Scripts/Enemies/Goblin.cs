using UnityEngine;

public class Goblin : Character
{
    void Start()
    {
        this.health = 1000;
    }

    void Update()
    {
        animator.SetTrigger("Attack");
    }
}