using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeCost_tag : MonoBehaviour
{
    public GameObject gVar;

    int coin ;

    [SerializeField] int costOfTheme1;
    [SerializeField] int costOfTheme2;

    public void buyTheme1()
    {       
        
        coin = gVar.GetComponent<globalVar>().GetCoin();

        if(coin>costOfTheme1 && gVar.GetComponent<globalVar>().getTheme1() == 0)
        {
            gVar.GetComponent<globalVar>().setTheme1(1);
            gVar.GetComponent<globalVar>().subCoin(costOfTheme1);
        }
    }

    public void buyTheme2()
    {
        coin = gVar.GetComponent<globalVar>().GetCoin();

        if(coin>costOfTheme2 && gVar.GetComponent<globalVar>().getTheme2() == 0)
        {
            gVar.GetComponent<globalVar>().setTheme2(1);
            gVar.GetComponent<globalVar>().subCoin(costOfTheme2);
        }
    }

}
