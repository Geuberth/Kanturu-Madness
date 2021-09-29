using UnityEngine;
using UnityEngine.UI;

public class Energy_Bar : MonoBehaviour
{
    public Image energyEffectImg;
    public Image energyImg;
    [SerializeField] private float maxEnergy;
    [SerializeField] private float energySpeed = 0.005f;

    private void Update()
    {
        if (energyEffectImg.fillAmount > energyImg.fillAmount)
        {
            energyEffectImg.fillAmount -= energySpeed;
        }
        else
        {
            energyEffectImg.fillAmount = energyImg.fillAmount;
        }
    }

    public void FillBar()
    {
        energyEffectImg.fillAmount = 1;
    }

    public void FillBarByAmount(float amount)
    {
        if (energyEffectImg.fillAmount + amount > 1)
        {
            energyEffectImg.fillAmount = 1;
        }
        else
        {
            energyEffectImg.fillAmount += amount;
        }
    }
    public void TakeEnergy(float energy, float currentEnergy)
    {
        energyEffectImg.fillAmount = currentEnergy / energy;
    }
}
