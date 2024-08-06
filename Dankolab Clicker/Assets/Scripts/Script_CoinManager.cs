using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class Script_CoinManager : MonoBehaviour
{

    public int InitialBalance = 0;
    int currentCoinBalance;
    public int CoinPerClick = 1;
    public int UpgradeCost = 20;
    int currentLevel = 1;
    public Text coinAmountLabel;
    public Text levelLabel;
    public Text mineButtonLabel;
    public Text upgradeCostLabel;


    // Start is called before the first frame update
    void Start()
    {
        currentCoinBalance = InitialBalance;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    void UpdateLabels()
    {
        coinAmountLabel.text = currentCoinBalance.ToString();
        levelLabel.text = "LV " + currentLevel.ToString();
        mineButtonLabel.text = "+" + CoinPerClick.ToString();
        upgradeCostLabel.text = "UPGRADE " + UpgradeCost.ToString();
    }

    public void MineCoin()
    {
        currentCoinBalance += CoinPerClick;
        UpdateLabels();
    }

    public void UpgradeMiner()
    {
        if (currentCoinBalance < UpgradeCost) return;

        currentCoinBalance -= UpgradeCost;
        currentLevel++;
        CoinPerClick = CoinPerClick * 2;
        UpgradeCost = (int)Math.Round(UpgradeCost * 2.5);

        UpdateLabels();
    }

    public void SetCurrentBalance(int coinAmount)
    {
        currentCoinBalance = coinAmount;
        UpdateLabels();
    }

    public void AlterCurrentBalance(int coinAmount)
    {
        currentCoinBalance += coinAmount;
        UpdateLabels();
    }

    /// <summary>
    /// Processes purchases after basic coin balance checks
    /// </summary>
    /// <param name="price">Amount of coins expended in a purchase</param>
    /// <returns>True if purchase was successful, false if not enough coins</returns>
    public bool ProcessPurchase(int price)
    {
        if (price > currentCoinBalance) return false;
        currentCoinBalance -= price;
        UpdateLabels();
        return true;
    }

}
