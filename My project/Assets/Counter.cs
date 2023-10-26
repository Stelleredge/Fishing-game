using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter instance;
    public TMP_Text coinText;
    public int currentCoins = 0;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = "COINS: " + currentCoins.ToString();
    }
    public void IncreaseCoins (int v)
    {
        currentCoins += v;
        coinText.text = "COINS: " + currentCoins.ToString();
    }
}
