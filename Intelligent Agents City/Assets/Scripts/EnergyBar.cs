using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnergyBar : MonoBehaviour
{
    public Slider slider_energy;
    public Gradient gradient;

    public void setMaxEnegry(int energy)
    {
        slider_energy.maxValue = energy;
        slider_energy.value = energy;
    }

    public void SetEnergy(int energy)
    {
        slider_energy.value = energy;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
