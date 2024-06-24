using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nextScene : MonoBehaviour
{
    public string sceneName;
    public void tONextScene()
    {
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
        }
        
        SceneManager.LoadScene(sceneName);
    
    }
}
