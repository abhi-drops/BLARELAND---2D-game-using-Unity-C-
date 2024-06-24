using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr_powerDistroy : MonoBehaviour
{
    public GameObject gVar;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Powerup")
        {   
            gVar.GetComponent<globalVar>().gameOver();
        }
    }
}
