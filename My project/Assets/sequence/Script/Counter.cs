using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter instance;
    public TMP_Text countText;
    public int currentCount = 0;
    private int totalCoins = 0;
    
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        countText.text = "Count: " + currentCount.ToString();
    }
    public void IncreaseCount (int v)
    {
        currentCount += v;
        countText.text = "Count: " + currentCount.ToString();
    }

    public void IncreaseCoins(int amount)
    {
        totalCoins += amount;
        UpdateCoinText();
    }

    public int GetTotalCoins()
    {
        return totalCoins;
    }

    private void UpdateCoinText()
    {
        // Assuming you have a reference to the CoinCounter script
        CoinCounter coinCounter = FindObjectOfType<CoinCounter>();
        if (coinCounter != null)
        {
            coinCounter.UpdateCoinText();
        }
    }
}
