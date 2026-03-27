using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    int coins = 0;

    public void UpdateCoins()
    {
        TextMeshProUGUI coinText = GetComponent<TextMeshProUGUI>();
        coins++;
        coinText.text = $"{coins}";
    }
}
