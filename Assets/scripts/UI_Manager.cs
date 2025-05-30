using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public void UpdateMoney (string money)
    {
        txtMoney.text = "$"+ money;
    }
}
