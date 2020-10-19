using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDetails : MonoBehaviour
{
    public int baseMoney = 100;
    public int currentMoney = 0;


    private void Start()
    {
        currentMoney = PlayerPrefs.GetInt("Money", currentMoney);
        
    }
    public void updateCurrentMoney(int money)
    {
        currentMoney += money;
    }
    private void Update()
    {
       
        if (currentMoney < 100)
            baseMoney = 10;
        else baseMoney = currentMoney / 20;
        PlayerPrefs.SetInt("Money", currentMoney);
        PlayerPrefs.Save();
    }
}
