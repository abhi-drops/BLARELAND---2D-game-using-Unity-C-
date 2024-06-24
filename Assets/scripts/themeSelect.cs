using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeSelect : MonoBehaviour
{
    public GameObject gVar;

    public void theme0()
    {
         globalVar.currentTheme = 0;
    }

    public void theme1()
    {
        if(gVar.GetComponent<globalVar>().getTheme1() == 1)
        {
            globalVar.currentTheme = 1;
        }
        
    }

    public void theme2()
    {   
        if(gVar.GetComponent<globalVar>().getTheme2() == 1)
        {
            globalVar.currentTheme = 2;
        }
    }
}
