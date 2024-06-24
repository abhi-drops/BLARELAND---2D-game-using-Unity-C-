using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossEnemy : MonoBehaviour
{   
    public GameObject bombPrefab ;
    float timer = 0f;
    Rigidbody2D rb;

    public GameObject gVar;

    public ParticleSystem bossEnemyDeathParticle;


    [SerializeField] int bossEnemyHealth = 5;


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
        float timegap2 = Random.Range(2,20);
        


        //bomb spawning1
        if(timer<= timegap)
        {
            timer+= Time.deltaTime;
        }
        else{
            timer=0;

            Instantiate(bombPrefab,rb.transform.position,rb.transform.rotation);
        }

        //bomb spawning2
        if(timer<= timegap2)
        {
            timer+= Time.deltaTime;
        }
        else{
            timer=0;

            Instantiate(bombPrefab,rb.transform.position,rb.transform.rotation);
        }

        // DESTROY BOSSENEMY : when health = 0
        if(bossEnemyHealth <= 0)
        {
            gVar.GetComponent<globalVar>().addScore(gVar.GetComponent<globalVar>().bossEnemyScore);
            Instantiate(bossEnemyDeathParticle,gameObject.transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        

    }

    //if enemy collides with player : GAME OVER
     private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Player")
        {
            
            gVar.GetComponent<globalVar>().gameOver();
            Destroy(gameObject);

        }
        //when it collide with bullet : reduce health
        else if(other.gameObject.tag == "Bullet")
        {   
            bossEnemyHealth--;
        }
            
        
    }
}

