using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class score_display : MonoBehaviour
{   

    public TMP_Text scoreUi;
    public TMP_Text highScoreUi;

    public TMP_Text highScorerUi;

    
    

    
    void Update()
    {   
        //updates score & high score

        highScorerUi.text = gameObject.GetComponent<globalVar>().getHighScorerName();
        highScoreUi.text = "HIGH SCORE : " + gameObject.GetComponent<globalVar>().getHighScore();
        scoreUi.text = ""+ gameObject.GetComponent<globalVar>().getScore();
    }
}
