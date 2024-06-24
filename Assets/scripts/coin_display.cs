using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin_display : MonoBehaviour
{
    public TMP_Text coinUi;

    void Update()
    {
        coinUi.text = ""+gameObject.GetComponent<globalVar>().GetCoin();
    }
}
