using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public float fallingRate;
    public int ballNumber;
    public float jackpotWinningChance,jackpotLosingChance;



    private void Start()
    {
        int baseMoney = FindObjectOfType<GameDetails>().baseMoney;
       
        int randomBallChoser = Random.Range(1, 4);
        if (randomBallChoser == 1)
        {
            ballNumber = Random.Range(baseMoney / 6, baseMoney/2 );
            jackpotWinningChance = 1;
            jackpotLosingChance = 0;
        }
        else
        {
            float jackpotMoneyMultiplier = Random.Range(1f, 10f);
            jackpotWinningChance = (1/(jackpotMoneyMultiplier*jackpotMoneyMultiplier));
            print(jackpotMoneyMultiplier);
            print(jackpotWinningChance);
            jackpotLosingChance = 1 - jackpotWinningChance;
            ballNumber = (int)((baseMoney) * jackpotMoneyMultiplier);

        }
    }
    

    private void Update()
    {
        transform.position += new Vector3(0, fallingRate, 0) * Time.deltaTime;
       

    }
}
