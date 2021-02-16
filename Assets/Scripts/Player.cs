using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode right;
    public KeyCode left;
    public GameObject player;
    public float speed;

    public void Update()
    {
        if (Input.GetKey(right))
        {
            player.transform.Translate(new Vector2(speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(left))
        {
            player.transform.Translate(new Vector2(-speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(down))
        {
            {
                player.transform.Translate(new Vector2(0, -speed * Time.deltaTime));
            }
        }

        if (Input.GetKey(up))
        {
            {
                player.transform.Translate(new Vector2(0, speed * Time.deltaTime));
            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Debug.Log("Death");
        }
    }
}
