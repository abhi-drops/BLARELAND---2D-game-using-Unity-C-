using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{   
    public float speed = 50f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    public GameObject gVar;

    public ParticleSystem enemyDeathParticle;



    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,speed*Time.deltaTime);
        screenBounds=Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
    }



    // Update is called once per frame
    void Update()
    {   
        // DESTROY BULLETS that goes above twice the height of screen

        if(transform.position.y>screenBounds.y*2){
            Destroy(this.gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        

        //when bullet collides with the enemy : DESTROY BULLET & ENEMY

        if(other.gameObject.tag == "Enemy")
        {   
            gVar.GetComponent<globalVar>().addScore(gVar.GetComponent<globalVar>().enemyScore);
            Instantiate(enemyDeathParticle,other.transform.position,Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
            
        }
            
        
    }
}
