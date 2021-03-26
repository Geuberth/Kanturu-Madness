using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{

    //public Slider slider;
    public Image healthEffectImg;
    public Image healthImg;
    [SerializeField] private float maxHp;

    private float Hp;
    [SerializeField]
    private float hurtSpeed = 0.005f;

    private void Start() {
        Hp = maxHp;
    }
    private void Update() {
        Debug.Log(Hp);
        healthImg.fillAmount = Hp / maxHp;
        if (healthEffectImg.fillAmount > healthImg.fillAmount) {
            healthEffectImg.fillAmount -= hurtSpeed;
        }
        else {
            healthEffectImg.fillAmount = healthImg.fillAmount;
        }
    }
    public void TakeDamage(){
        this.Hp -= 10;
    }
}
