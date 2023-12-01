using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject ingame;
    public bool isgamestart=false;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        ingame.SetActive(false);
    }
    // Start is called before the first frame update
    public void StartGame()
    {
        Time.timeScale = 1;
        isgamestart = true;
        ingame.SetActive(true);
    }
    public void StopGame()
    {
        Time.timeScale = 0;
        Tapbuttonscript.instance.ShowMenu();
        Debug.Log("game pased2");
    }
}
