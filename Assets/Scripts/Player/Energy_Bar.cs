using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Energy_Bar : MonoBehaviour
{
    //public Slider slider;
    public Image energyEffectImg;
    public Image energyImg;
    [SerializeField] private float maxEnergy;

    [HideInInspector]  public float energy;
    [SerializeField]
    private float energySpeed = 0.005f;

    private void Start() {
        energy = maxEnergy;
    }
    private void Update() {
        Debug.Log(energy);
        energyImg.fillAmount = energy / maxEnergy;
        if (energyEffectImg.fillAmount > energyImg.fillAmount) {
            energyEffectImg.fillAmount -= energySpeed;
        }
        else {
            energyEffectImg.fillAmount = energyImg.fillAmount;
        }
    }
    public void TakeEnergy() {
        this.energy -= 10;
    }
}
