using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float money;

    public void UpdateMoney(float amount) { 
        if (money + amount < 0)
        {
            //frena la compra
            Debug.Log("Dinero Insuficiente");
        }
        else
        {
            money += amount;
        }
        
    }
}
