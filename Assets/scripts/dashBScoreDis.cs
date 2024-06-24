using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dashBScoreDis : MonoBehaviour
{   
    
    public TMP_Text scoreUi;
    public TMP_Text highScoreUi;

    public GameObject gameOverSound;
   
   
    
    private void Start() {
        if(globalVar.gameloss == true)
        {
            globalVar.gameloss = false;
            GameObject b = Instantiate(gameOverSound) as GameObject;
        }
    }
    // Update is called once per frame
    void Update()
    {
        highScoreUi.text = "HIGH-SCORE : " + gameObject.GetComponent<globalVar>().getHighScore() + " ("+gameObject.GetComponent<globalVar>().getHighScorerName() + ")";
        scoreUi.text = "SCORE: "+ globalVar.lastScore;
    }
}
