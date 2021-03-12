using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CombatManager : MonoBehaviour {
    public static CombatManager instance;
    public bool canreceiveInput;
    public bool inputReceive;


    public Animator animator;
    public Transform AttackPoint;
    public float Attackrange;
    public LayerMask EnemyLayers;
    public int AttackDamage = 50;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Attack();
    }


    public void Attack() {
        if (Input.GetButtonDown("Fire1")) {
            Collider2D[] HitEnemy = Physics2D.OverlapCircleAll(AttackPoint.position, Attackrange, EnemyLayers);
            foreach (Collider2D enemy in HitEnemy) {
                enemy.GetComponent<Enemy>().TakeDamage(AttackDamage);
            }
            if (canreceiveInput) {
                inputReceive = true;
                canreceiveInput = false;
            }
        }
    }

    public void InputManager() {
        if (!canreceiveInput) {
            canreceiveInput = true;
        }
        else {
            canreceiveInput = false;
        }

    }

    void OnDrawGizmosSelected() {
        if (AttackPoint == null)
            return;
        Gizmos.DrawWireSphere(AttackPoint.position, Attackrange);
    }
}
