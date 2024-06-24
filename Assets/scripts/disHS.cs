using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class disHS : MonoBehaviour
{
   public TMP_Text highScoreLargeUi;

    // Update is called once per frame
    void Update()
    {
        highScoreLargeUi.text = ""+ gameObject.GetComponent<globalVar>().getHighScore();
    }
}
