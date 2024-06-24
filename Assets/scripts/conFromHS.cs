using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class conFromHS : MonoBehaviour
{   
    public GameObject inputField;

    public GameObject gVar;

   public void continueFromHs()
   {
        string username = inputField.GetComponent<TMP_InputField>().text;;
        gVar.GetComponent<globalVar>().setHighScorerName(username);

        HighScores.UploadScore(username,gVar.GetComponent<globalVar>().getHighScore());
        SceneManager.LoadScene("dashboard");
        
   }
}
