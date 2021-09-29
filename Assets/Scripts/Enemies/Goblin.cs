using System.Collections;
using UnityEngine;

public class Goblin : Character
{
    private bool foundPlayer;
    void Start()
    {
        this.health = 1000;
    }

    void Update()
    {
        if (foundPlayer)
        {
            left = false;
        }
        else
        {
            left = true;
        }

        CheckGround();
        CheckMove();
        CheckPlayers();

    }

    private void CheckPlayers()
    {
        Collider2D[] HitTargets = Physics2D.OverlapCircleAll(AttackPoint.position, Attackrange, Layer);
        foreach (Collider2D character in HitTargets)
        {
            if (character.enabled)
            {
                foundPlayer = true;
                DoDamage();
            }
        }

    }

    IEnumerator Attack(){
        yield return new WaitForSeconds(3);
    }
    protected override void DoDamage()
    {
        StartCoroutine(Attack());
        animator.SetTrigger("Attack");
        base.DoDamage();
    }


}