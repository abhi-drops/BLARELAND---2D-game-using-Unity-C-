using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{   
    public GameObject bombPrefab ;
    float timer = 0f;
    Rigidbody2D rb;

    public GameObject gVar;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {   
        
        // random timegap for bomb spawning
        float timegap = Random.Range(2,20);


        //bomb spawning
        if(timer<= timegap)
        {
            timer+= Time.deltaTime;
        }
        else{
            timer=0;

            Instantiate(bombPrefab,rb.transform.position,rb.transform.rotation);
        }
    }

    //if enemy collides with player : GAME OVER
     private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Player")
        {
            
            
            gVar.GetComponent<globalVar>().gameOver();
            Destroy(gameObject);

        }
            
        
    }
}

