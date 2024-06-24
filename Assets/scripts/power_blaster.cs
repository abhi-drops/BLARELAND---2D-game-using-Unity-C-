using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_blaster : MonoBehaviour
{   
    public bool blast = false;
    [SerializeField] GameObject Rangec;
    CircleCollider2D cr;

    private void Start() {

         cr = Rangec.gameObject.GetComponent<CircleCollider2D>();
    }


    // enable circle collider 2d in range gameobject (child game object ) if it collides with player or bullet
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Bullet")
        {
            blast = true;
            cr.enabled = true;

            // DESTROY BULLET
            if(other.gameObject.tag == "Bullet")
            {
                Destroy(other.gameObject);
            }
        }
    }



}
