using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;


public class UpgradesManager : MonoBehaviour
{
    SwordStats SwordStats;
    Gold Gold;

    public int AttackCost;
    public int DpsCost;

    [SerializeField] Text AtkCostText;
    [SerializeField] Text DpsCostText;

    void Awake()
    {
        Gold = GameObject.Find("Gold").GetComponent<Gold>();
        SwordStats = GameObject.Find("Sword").GetComponent<SwordStats>();
    }

    private void Start()
    {
        AttackCost = 1;
        DpsCost = 5;

        AtkCostText.text = "Cost: " + AttackCost;
        DpsCostText.text = "Cost: " + DpsCost;

    }

    public void IncreaseAtk() { 
        if(Gold.GoldAmount >= AttackCost) 
        {
            Gold.GoldAmount -= AttackCost;
            SwordStats.Attack += 1;

            SwordStats.AttackText.text = "Attack: " + SwordStats.Attack;

            AttackCost += 1;
            AtkCostText.text = "Cost: " + AttackCost;
            Gold.RefreshGold();
        }
    }

    public void MaxIncreaseAtk()
    {
        if (Gold.GoldAmount >= AttackCost)
        {
            while(Gold.GoldAmount >= AttackCost)
            {
                IncreaseAtk();
            }
        }
    }

    public void IncreaseDps()
    {
        if (Gold.GoldAmount >= DpsCost)
        {
            Gold.GoldAmount -= DpsCost;
            SwordStats.Dps += 0.1f;

            SwordStats.DpsText.text = "Dps: " + string.Format("{0:0}", SwordStats.Dps * 10);

            DpsCost += 5;
            DpsCostText.text = "Cost: " + DpsCost;
            Gold.RefreshGold();
        }

    }
    public void MaxIncreaseDps()
    {
        if (Gold.GoldAmount >= DpsCost)
        {
            while (Gold.GoldAmount >= DpsCost)
            {
                IncreaseDps();
            }
        }
    }
}
