using UnityEngine;
using UnityEngine.UI;

public class Health_Bar : MonoBehaviour
{
    public Image healthEffectImg;
    public Image healthImg;
    [SerializeField] private float hurtSpeed = 0.005f;

    private void Update()
    {

        if (healthEffectImg.fillAmount > healthImg.fillAmount)
        {
            healthEffectImg.fillAmount -= hurtSpeed;
        }
        else
        {
            healthEffectImg.fillAmount = healthImg.fillAmount;
        }
    }

    public void FillBar()
    {
        healthEffectImg.fillAmount = 1.0f;
    }
    public void FillBarByAmount(float amount)
    {
        if (healthEffectImg.fillAmount + amount > 1.0f)
        {
            healthEffectImg.fillAmount = 1.0f;
        }
        else
        {
            healthEffectImg.fillAmount += amount;
        }
    }
    public void TakeDamage(float hp, float currentHealth)
    {
        healthImg.fillAmount = currentHealth / hp;
        Debug.Log(healthImg.fillAmount);
    }
}
