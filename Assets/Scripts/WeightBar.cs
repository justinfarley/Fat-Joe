using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightBar : MonoBehaviour
{
    public Slider slider;

    public JoeStats Joe;

    public Gradient gradient;

    public Image fill;

    void Start()
    {
        
    }
    public void SetWeight(int weight)
    {
        slider.value = weight;
    }

    public void SetMaxWeight()
    {
        slider.maxValue = 200;
        slider.value = Joe.weight;
    }
}
