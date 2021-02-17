using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthdrain : MonoBehaviour
{
    public Health health;
    public Image fill;
    private Slider slider;
    
    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    private void Update()
    {
        float fillvalue = health.curheath / health.maxhealth;
        slider.value = fillvalue;
    }
}
