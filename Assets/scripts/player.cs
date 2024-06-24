using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{   
    float horizontal;
    
    Rigidbody2D body;
    public float runSpeed = 20f;
    public GameObject bulletPrefab;
    public GameObject gVar;

    

    int lv;

    int TapCount;
    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        lv = gVar.GetComponent<globalVar>().getSpeedLevel();

         if(lv == 1)
        {
            runSpeed = 8f;
        }
        else if (lv == 2)
        {
            runSpeed = 10f;
        }
        else if (lv == 3)
        {
            runSpeed = 11f;
        }
        else if (lv == 4)
        {
            runSpeed = 12f;
        }
        else if (lv == 5)
        {
            runSpeed = 13f;
        }
        
         
    }

    // Update is called once per frame
    void Update()
    {   
       
        //keyboard input

        horizontal=Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown("space")){
            shootBullet();
        }
    }


    //movement : apply velocity
    private void FixedUpdate() {
        
      
       
        body.velocity= new Vector2(horizontal * runSpeed,0);
       
        
    }

    //shoot bullet
    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = GetComponent<Transform>().position;
    }

   
}
