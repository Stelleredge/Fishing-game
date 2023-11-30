using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter instance;
    public TMP_Text countText;
    public int currentCount = 0;
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
}
