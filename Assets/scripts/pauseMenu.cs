using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pauseMenu : MonoBehaviour
{   
    public Canvas pMenu;
    /*
    public CrazyBanner banner1;
    public CrazyBanner banner2;    
    */
    public void resume()
    {
        pMenu.GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1f;
        /*
        banner1.MarkVisible(false);
        banner2.MarkVisible(false);
         banner1.gameObject.SetActive(false);
        banner2.gameObject.SetActive(false);
        */
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("mainMenu");
    }

    public void settingsMenu()
    {
        SceneManager.LoadScene("settings");
    }

    public void quitGame()
    {
        
        Application.Quit();
    }

    public void newGame()
    {   
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }

        
        SceneManager.LoadScene("newGame");
    }

    public void credits()
    {
        SceneManager.LoadScene("credits");
    }
}
