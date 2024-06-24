using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class reviveMenu : MonoBehaviour
{   
    public static int reviveT = 0;
    

     GameObject gVar;

    // Start is called before the first frame update
    void Start()
    {
        gVar = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void revive()
    {
        if(reviveT < 2)
        {
            

            
            
        }
    }

    public void continueGame()
    {
        Time.timeScale = 1f;
        
        reviveT = 2;
        gVar.GetComponent<globalVar>().gameOver();
    }

    void adsRevive()
    {
            print("revive");
            reviveT++;
            globalVar.RMenu = false;
            Time.timeScale = 1f;
    }
    void adsError()
    {
        print("adError");
        adsRevive();
    }
}
