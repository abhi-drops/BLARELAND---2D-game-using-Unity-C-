using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class pause : MonoBehaviour
{   
    public Canvas pauseMenu;
    /*
    public CrazyBanner banner1;
    public CrazyBanner banner2;
    

    // Start is called before the first frame update
    void Start()
    {
         banner1.gameObject.SetActive(false);
        banner2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    public void pauseButton()
    {
       
        pauseMenu.GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0f;
        
        /*
         banner1.gameObject.SetActive(true);
        banner2.gameObject.SetActive(true);
        banner1.MarkVisible(true);
        banner2.MarkVisible(true);
        CrazyAds.Instance.updateBannersDisplay();
        */
    }

    
}
