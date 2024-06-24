using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class themestore : MonoBehaviour
{   
    public GameObject gVar;

    int t1;
    int t2;

    int ct;

    public GameObject costTag1;
    public GameObject costTag2;

    public GameObject selUi0;
    public GameObject selUi1;
    public GameObject selUi2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t1 = gVar.GetComponent<globalVar>().getTheme1();
        t2 = gVar.GetComponent<globalVar>().getTheme2();
        ct = globalVar.currentTheme;
        
        //costtag visiable and invisiable 
        if (t1 == 0)
        {
            //theme1 is locked
            costTag1.gameObject.SetActive(true);
        }
        else
        {
            costTag1.gameObject.SetActive(false);
            //theme1 is unlocked
        }

        if (t2 == 0)
        {
            costTag2.gameObject.SetActive(true);
            //theme2 is locked
        }
        else
        {
            costTag2.gameObject.SetActive(false);
            //theme2 is unlocked
        }


        //selecttag visiable and invisiable 
        if(ct == 0)
        {
            selUi0.gameObject.SetActive(true);
            selUi1.gameObject.SetActive(false);
            selUi2.gameObject.SetActive(false);
            //selected theme 0
        }
        else if(ct == 1)
        {
            selUi0.gameObject.SetActive(false);
            selUi1.gameObject.SetActive(true);
            selUi2.gameObject.SetActive(false);
            //selected theme 1
        }
        else if(ct == 2)
        {
            selUi0.gameObject.SetActive(false);
            selUi1.gameObject.SetActive(false);
            selUi2.gameObject.SetActive(true);
            //selected theme 2
        }
    }
}
