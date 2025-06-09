using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float HP;
    public UI_Manager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UI_Manager>();
    }


    public bool UpdateHP (float damage)
    {
        if (HP <= damage)
        {
          
            SceneManager.LoadScene("Parkour");
            return false;
        }
        else
        {
            HP -= damage;
            uiManager.UpdateHPText(HP.ToString());
            return true;
        }

    }
}

