using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshot : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector2 target;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
     
    }

  
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
           
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            Destroyplayer();
        }
    }

    void Destroyplayer()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player"))
        {
            Destroyplayer();
        }
    }
}
