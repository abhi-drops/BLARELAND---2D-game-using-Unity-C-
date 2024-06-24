using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bomb : MonoBehaviour
{   public GameObject gVar;

    //when bomb collide with the player : GAME OVER
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            
            
            gVar.GetComponent<globalVar>().gameOver();
            Destroy(gameObject);

        }
    }
}
