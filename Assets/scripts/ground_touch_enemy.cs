using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ground_touch_enemy : MonoBehaviour
{
    public GameObject gVar;
    private void OnTriggerEnter2D(Collider2D other) {

        //if enemy or bossenemy touches the ground : GAME OVER
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Bossenemy")
        {
            Destroy(other.gameObject);
            gVar.GetComponent<globalVar>().gameOver();

        }
        //if touches the ground : DESTROY BOMB OR POWERUP 
        else if(other.gameObject.tag == "Bomb" || other.gameObject.tag == "Powerup")
        {   
            Destroy(other.gameObject);
        }
            
        
    }
    
}
