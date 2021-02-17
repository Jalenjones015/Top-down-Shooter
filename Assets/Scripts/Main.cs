using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public string Sn;

    public void Startp()
    {
        SceneManager.LoadScene(Sn);
        Debug.Log("start");
    }

    public void close()
    {
        Application.Quit();
        Debug.Log("quit");
    }

    public void back()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("back");
    }

    public void Replay()
    {
        FindObjectOfType<Manager>().Reset();
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Reset");
    }
}
