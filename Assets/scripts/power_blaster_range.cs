using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_blaster_range : MonoBehaviour
{   
    // if range collides with enemy or boss enemy : DESTROY : ENEMY & BOSSENEMY 
    // and if collides with anygame object destroy parent (: DESTROY POWER BLASTER );(note: collition is only enabled when it's parent object is collided with player or bullet)
    [SerializeField] GameObject parent; 
    public GameObject gVar;

    public ParticleSystem pu_enemy_death;
    public ParticleSystem pu_boss_enemy_death;
    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "Bossenemy" )
        {
            gVar.GetComponent<globalVar>().addScore(gVar.GetComponent<globalVar>().bossEnemyScore);
            Instantiate(pu_boss_enemy_death,other.transform.position,Quaternion.identity);
            Destroy(other.gameObject);
        }

        else if(other.gameObject.tag == "Enemy")
        {
            gVar.GetComponent<globalVar>().addScore(gVar.GetComponent<globalVar>().enemyScore);
            Instantiate(pu_enemy_death,other.transform.position,Quaternion.identity);
            Destroy(other.gameObject);
        }


        Destroy(parent.gameObject);
    }
}
