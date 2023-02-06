using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : Spawner
{
    protected int maxEnemy = 5;

    private void Awake()
    {
        this.objPrefab = GameObject.Find("EnemyPrefab");
        this.objPrefab.SetActive(false);
        this.spawnPosition = GameObject.Find("EnemySpawnPosition");

        this.objects = new List<GameObject>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();
        this.CheckEnemyDead();
    }
    
    protected virtual void Spawn()
    {
        if (PlayerController.instance.damageReceiver.isDead())
        {
            return;
        }
        this.spawnTimer += Time.deltaTime;
        if(this.spawnTimer < this.spawnDelay) return;

        this.spawnTimer = 0f;
        if (this.objects.Count >= this.maxEnemy) return;
        GameObject enemy = Instantiate(this.objPrefab);
        enemy.name = "Enemy #" + this.objects.Count;
        enemy.transform.position = spawnPosition.transform.position;
        enemy.transform.parent = transform;
        enemy.SetActive(true);
        this.objects.Add(enemy);
    }

    void CheckEnemyDead()
    {
        GameObject enemy;
        for (int i = 0; i < this.objects.Count; i++)
        {
            enemy = this.objects[i];
            if(enemy == null) this.objects.RemoveAt(i);
        }
    }
}
