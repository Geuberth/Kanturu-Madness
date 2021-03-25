using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    int MaxHealth = 100;
    int currentHealth; 
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;

    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        Debug.Log(currentHealth);

        //Play Hurt animation 
        animator.SetTrigger("Hurt");
        
        if(currentHealth <= 0){

            Die();
        }
    }

    void Die(){
        animator.SetBool("Isdead",true);
        GetComponent<Collider2D>().enabled = true;
        this.enabled = false;
    }

}
