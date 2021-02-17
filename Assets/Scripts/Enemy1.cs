using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float speed;
    public float retreat;
    public Transform enemy;
    private float betweenshots = .1f;
    public float startbetweenshots  = 0f;
    public GameObject bullet;

    public void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        betweenshots = startbetweenshots;
    }

    public void Update()
    {
       
        if(Vector2.Distance(transform.position, enemy.position) > retreat)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, enemy.position) < retreat)
        {
            transform.position = Vector2.MoveTowards(transform.position, enemy.position, -speed * Time.deltaTime);
        }


        if(betweenshots <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            betweenshots = startbetweenshots;
            
        }

        else
        {
            betweenshots -= Time.deltaTime;
        }
    }
}
