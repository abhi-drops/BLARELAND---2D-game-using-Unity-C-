using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music_controller : MonoBehaviour
{   
    private static music_controller playerInstance;
    public string exceptionScene1;
    public string exceptionScene2;

    private void Awake()
    {
        
        DontDestroyOnLoad(this);

        if (playerInstance == null) 
        {
            playerInstance = this;
        }
        else 
        {
             Destroy(gameObject);
        }
    }
    void Update()
 {
     Scene currentScene = SceneManager.GetActiveScene();
 
     if (currentScene.name == exceptionScene1 || currentScene.name == exceptionScene2)
     {
         // Stops playing music in level 1 scene
         Destroy(gameObject);
     }
 }

   
}
