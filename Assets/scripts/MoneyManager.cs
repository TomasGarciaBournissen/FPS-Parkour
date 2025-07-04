﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float money;
    public UI_Manager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UI_Manager>();
    }

    public bool UpdateMoney(float amount) { 
        if (money + amount < 0)
        {
            //frena la compra
            Debug.Log("Dinero Insuficiente");
            return false;
        }
        else
        {
            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }
        
    }
}
