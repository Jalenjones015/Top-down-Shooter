using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Player player;
    public Vector2 ps;
    public GameObject win;
    public GameObject lose;

    void Start()
    {
        ps = player.transform.position;
    }

    public void Win()
    {
        win.SetActive(true);
        player.gameObject.SetActive(false);
    }

    public void Lose()
    {
        lose.SetActive(true);
        player.gameObject.SetActive(false);
    }

    public void Reset()
    {
        win.SetActive(false);
        lose.SetActive(false);
        player.gameObject.SetActive(true);
        player.transform.position = ps;
    }
}

