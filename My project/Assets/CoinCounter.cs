using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    // Start is called before the first frame update
    void Start()
    {
        UpdateCoinText();
    }

    public void UpdateCoinText()
    {
        coinText.text = "Coins: " + Counter.instance.GetTotalCoins().ToString();
    }
}

