using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health = 100f;
    private Image bar;
    public float curheath;
    private float maxhealth = 100f;
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
