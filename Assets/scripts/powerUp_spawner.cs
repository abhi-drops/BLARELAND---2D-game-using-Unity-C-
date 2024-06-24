using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp_spawner : MonoBehaviour
{   
    public Transform[] spawnPoints;

    public GameObject[] powerUpPrefabs;

    float timer = 0f;

    [SerializeField] float timegap = 15f;
    [SerializeField] float timeAdd = 5f;


    // Update is called once per frame
    void Update()
    {
        if(timer<= timegap)
        {
            timer+= Time.deltaTime;
            
        }
        else{
            timer=0;
            int randPowerUp = Random.Range(0,powerUpPrefabs.Length);
            int randSpawnPoint = Random.Range(0,spawnPoints.Length);

            Instantiate(powerUpPrefabs[randPowerUp],spawnPoints[randSpawnPoint].position,transform.rotation);
            timegap = timegap + timeAdd;
        }

        if (timegap >= 45f)
        {
            timeAdd = 0;
        }
    }
}
