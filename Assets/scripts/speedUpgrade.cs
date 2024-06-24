using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class speedUpgrade : MonoBehaviour
{
    public GameObject gVar;

    int coin ;
    public TMP_Text costUi;
    public TMP_Text levelNameUi;

    
    [SerializeField] int costOfLevel2;
    [SerializeField] int costOfLevel3;
    [SerializeField] int costOfLevel4;
    [SerializeField] int costOfLevel5;

    [SerializeField] GameObject pButton;

    

    private void Update() {

        if(gVar.GetComponent<globalVar>().getSpeedLevel() == 1)
        {
            costUi.text = ""+costOfLevel2;
            levelNameUi.text = "LEVEL 1";
        }
        else if(gVar.GetComponent<globalVar>().getSpeedLevel() == 2)
        {
            costUi.text = ""+costOfLevel3;
            levelNameUi.text = "LEVEL 2";
        }
        else if (gVar.GetComponent<globalVar>().getSpeedLevel() == 3)
        {
            costUi.text = ""+costOfLevel4;
            levelNameUi.text = "LEVEL 3";
        }
        else if (gVar.GetComponent<globalVar>().getSpeedLevel() == 4)
        {
            costUi.text = ""+costOfLevel5;
            levelNameUi.text = "LEVEL 4";
        }
        else if (gVar.GetComponent<globalVar>().getSpeedLevel() == 5)
        {
            costUi.text = "";
            levelNameUi.text = "LEVEL 5";
            pButton.gameObject.SetActive(false);
        }
    }
    

    public void upgradeSpeed()
    {   
        
        int lv = gVar.GetComponent<globalVar>().getSpeedLevel();
        coin = gVar.GetComponent<globalVar>().GetCoin();

        if(lv == 1 && coin>costOfLevel2)
        {   
            gVar.GetComponent<globalVar>().saveSpeedLevel();
            gVar.GetComponent<globalVar>().setSpeedlevel(2);
            gVar.GetComponent<globalVar>().subCoin(costOfLevel2);
        }
        else if(lv == 2 && coin>costOfLevel3)
        {
            gVar.GetComponent<globalVar>().setSpeedlevel(3);
            gVar.GetComponent<globalVar>().subCoin(costOfLevel3);
        }
        else if (lv == 3 && coin>costOfLevel4)
        {
            gVar.GetComponent<globalVar>().setSpeedlevel(4);
            gVar.GetComponent<globalVar>().subCoin(costOfLevel4);
        }
        else if (lv == 4 && coin>costOfLevel5)
        {
            gVar.GetComponent<globalVar>().setSpeedlevel(5);
            gVar.GetComponent<globalVar>().subCoin(costOfLevel5);
        }
       
    } 
}
