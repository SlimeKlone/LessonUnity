using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    
    private int coinCount = 0;
    public TextMeshProUGUI coinText;

    public void AddCoin()
    {
        coinCount++;
        coinText.text = "Монетки: " + coinCount.ToString();
    }
}