using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BallSelector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI ballDetailsDisplay;
    [SerializeField] TextMeshProUGUI currentMoneyDisplay;
    [SerializeField] TextMeshProUGUI buyDisplay;
    [SerializeField] Button buyButtonClass ;
    int ballNumber=0;
    int winningChance =100;
    [SerializeField] GameDetails gameDetails;
    GameObject ballToBeDestroyed;
    int buyPrice= 0 ;
   
    Balls balls;
    // Update is called once per frame
    void Update()
    {

        currentMoneyDisplay.text = "Money\n" + gameDetails.currentMoney;
        buyPrice = (ballNumber * ( winningChance))/100;
        buyDisplay.text = "BUY\n" + buyPrice.ToString(); 
        //if ((Input.touchCount>0&&Input.touches[0].phase== TouchPhase.Began))
        if(Input.GetMouseButtonDown(0))
        {
           
            RaycastHit raycastHit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit, 10f))
            {
                ballToBeDestroyed = raycastHit.transform.gameObject;
                var r = raycastHit.transform.gameObject.GetComponent<Balls>();

                if (r != null)
                {
                    ballNumber = r.ballNumber;
                    winningChance = (int)(r.jackpotWinningChance * 100);
                }
                else
                {
                    ballNumber = 0;
                    winningChance = 0;
                } 
            }
       
        }
        if(ballToBeDestroyed == null)
        {
            ballNumber = 0;
            winningChance = 0;
        }
        ballDetailsDisplay.text = ballNumber.ToString()+"\n"+winningChance.ToString()+" %";
    }

    
    public void buyButton()
    {
        if(ballDetailsDisplay.text != null)
        {
            int randomChoser = Random.Range(1, 101);
            if (randomChoser <= winningChance)
                gameDetails.updateCurrentMoney(ballNumber);
            else gameDetails.updateCurrentMoney(-buyPrice);
            Destroy(ballToBeDestroyed);
            ballNumber = 0;
            ballDetailsDisplay.text = null;
        }
    }
}
