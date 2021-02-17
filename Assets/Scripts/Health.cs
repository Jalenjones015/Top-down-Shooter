using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private Image bar;
    public float curheath;
    public float maxhealth = 10f;
    Life player;

    private void Start()
    {
        bar = GetComponent<Image>();
        player = FindObjectOfType<Life>();
    }

    private void Update()
    {
        curheath = player.health;
        bar.fillAmount = curheath / maxhealth;
    }
}
