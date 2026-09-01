using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinButtonScript : MonoBehaviour
{

    public TextMeshProUGUI CoinNumberText, CoinUpgradeText;
    public Button GetCoinButton, UpgradeCoinButton;   
    int coinNumber = 0;
    int coinUpgrade = 5;
    int coinButtonIncrease = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetCoinButton.onClick.AddListener(AddCoin);
        UpgradeCoinButton.onClick.AddListener(UpgradeCoin);

        CoinNumberText.SetText($"You have {coinNumber} coins!!");
        CoinUpgradeText.SetText($"You need {coinUpgrade} coins to upgrade your coin button");
    }


    void AddCoin()
    {
        coinNumber += coinButtonIncrease;
        CoinNumberText.SetText($"You have {coinNumber} coins!!");

        if (coinNumber >= coinUpgrade)
        {
            UpgradeCoinButton.interactable = true;
        }
    }

    void UpgradeCoin()
    {
        coinNumber -= coinUpgrade;
        coinButtonIncrease += 2;
        coinUpgrade = coinUpgrade * 2;
        UpgradeCoinButton.interactable = false;
        CoinNumberText.SetText($"You have {coinNumber} coins!!");
        CoinUpgradeText.SetText($"You need {coinUpgrade} coins to upgrade your coin button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
