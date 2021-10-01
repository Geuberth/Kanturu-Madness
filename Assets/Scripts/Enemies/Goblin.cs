using System.Collections;
using UnityEngine;

public class Goblin : Character
{
    void Start()
    {
        health = 1000;
    }

    void Update()
    {
        CheckGround();
        CheckMove();
        CheckEnemies();
    }  

    IEnumerator Attack(){
        yield return new WaitForSeconds(3);
    }
    //protected override void DoDamage()
    //{
    //    StartCoroutine(Attack());
    //    GetComponent<Animator>().SetTrigger("Attack");
    //    base.DoDamage();
    //}
}