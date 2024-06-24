using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_enemy_spawner : MonoBehaviour
{   
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefab;

    public GameObject bossEnemyPrefab;

    float timer = 0f;
    float timer2 =0f;

    public float timegap = 2.75f;

    public float timesub = 0.001f;

    float t;

    bool isbossSpawned = false;

    public float bossTimeSub = 0.25f;

    [SerializeField] float bossIntervalForEnemy = 8f;

    [SerializeField] float bossTimegap = 20;
    [SerializeField] float bossIntTimegap =5;

    [SerializeField] float bossIntervalSub = 0.25f;

    bool firstBossSpawn = false;

    

    // Update is called once per frame
    void Update()
    {
        //spawn enemy in fixed time ; which is reducing in every enemy spawn until it turns 1

        if(timer<= timegap)
        {
            timer+= Time.deltaTime;
            
        }
        else{
            timer=0;
            int randEnemy = Random.Range(0,enemyPrefab.Length);
            int randSpawnPoint = Random.Range(0,spawnPoints.Length);

            Instantiate(enemyPrefab[randEnemy],spawnPoints[randSpawnPoint].position,transform.rotation);

            //restoring the timegap of enemy (after it was modifed when a boss is spawned)
            
            if(isbossSpawned)
            {
                timegap = t;

                isbossSpawned = false;
            }

            timegap = timegap - timesub;

        }

        if (timegap <= 1f)
        {
            timesub = 0;
        }

        // boss enemy spawner (intital spawn at $bossinttimegap & other spawn after each interval of $bosstimegap )
        //when boss spawnes it restricts the spawn of enemy for a fixed time && this fixed time is reduced in each
        // spawn of the boss till it reach a certain value

        if (timer2 <= bossIntTimegap)
        {
            timer2+= Time.deltaTime;
        }
        else{

            timer2 = 0;
            int randSpawnPoint2 = Random.Range(0,spawnPoints.Length);
            Instantiate(bossEnemyPrefab,spawnPoints[randSpawnPoint2].position,transform.rotation);

            t = timegap;
            timegap = bossIntervalForEnemy;
            isbossSpawned = true;

            if(!firstBossSpawn)
            {
                bossIntTimegap = bossTimegap;
                firstBossSpawn = true;
            }

            bossIntTimegap = bossIntTimegap - bossTimeSub;
            bossIntervalForEnemy = bossIntervalForEnemy - bossIntervalSub;
        }

        if (bossIntTimegap <= 8f)
        {
            bossTimeSub = 0;
        }

        if (bossIntervalForEnemy <= 2f)
        {
            bossIntervalSub = 0;
        }

    }
}
