using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Transform player;
    public float Smoove;
    public Vector2 min;
    public Vector2 max;

   

    private void LateUpdate()
    {
        if (transform.position != player.position)
        {
            Vector3 target = new Vector3(player.position.x, player.position.y, transform.position.z);
            target.x = Mathf.Clamp(target.x, min.x, max.x);
            target.y = Mathf.Clamp(target.y, min.y, max.y);
            transform.position = Vector3.Lerp(transform.position, target, Smoove);

        }
    }
}
