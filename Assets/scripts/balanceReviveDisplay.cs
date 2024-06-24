using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class balanceReviveDisplay : MonoBehaviour
{   
    public TMP_Text balanceChanceUi;

   

    // Update is called once per frame
    void Update()
    {
        balanceChanceUi.text = "(" + (2-reviveMenu.reviveT) + "/2)";
    }
}
