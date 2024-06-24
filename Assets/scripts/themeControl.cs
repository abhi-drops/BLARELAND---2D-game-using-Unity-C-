using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class themeControl : MonoBehaviour
{
    public GameObject gVar;
    public GameObject theme2;
    public GameObject theme3;

    private void Start() {
        int th = globalVar.currentTheme;

        if(th == 0)
        {
            theme2.GetComponent<Volume>().enabled = false ;
            theme3.GetComponent<Volume>().enabled = false ;
        }
        else if(th == 1)
        {
            theme2.GetComponent<Volume>().enabled = true ;
            theme3.GetComponent<Volume>().enabled = false ;
        }
        else if(th == 2)
        {
            theme2.GetComponent<Volume>().enabled = false ;
            theme3.GetComponent<Volume>().enabled = true ;
        }
    }
}
