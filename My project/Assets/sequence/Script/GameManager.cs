using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public static GameManager instance;
    private Spt_FishingHook fishinghook;
    private void Awake()
    {
        instance = this;
    }
    public void Startgame()
    {
        fishinghook.Start();

    }

}
