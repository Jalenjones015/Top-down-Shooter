using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthdrain : MonoBehaviour
{
    private float maxhp = 100, curhp;
    public float damage = 10;
    public Image bar;
    public GameObject player;
   

    public void Start()
    {
        curhp = maxhp;

    }

    public void Update()
    {
        bar.fillAmount = curhp / maxhp;
    }

    public void losehp()
    {
        curhp -= damage;
  
    }
}
