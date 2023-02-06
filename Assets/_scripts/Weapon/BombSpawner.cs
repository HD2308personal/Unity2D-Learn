using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : Spawner
{

    private void Awake()
    {
        this.objPrefab = GameObject.Find("BombPrefab");
        this.objPrefab.SetActive(false);
        this.spawnPosition = GameObject.Find("BombSpawnPosition");
        
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
        
        this.CheckBombExplosed();
    }
    
    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if(this.spawnTimer < this.spawnDelay) return;

        this.spawnTimer = 0f;
        if (this.objects.Count >= 7) return;
        GameObject bomb = Instantiate(this.objPrefab);
        bomb.name = "Bomb #" + this.objects.Count;
        bomb.transform.position = spawnPosition.transform.position;
        bomb.transform.parent = transform;
        bomb.SetActive(true);
        this.objects.Add(bomb);
    }


    void CheckBombExplosed()
    {
        GameObject bomb;
        for (int i = 0; i < this.objects.Count; i++)
        {
            bomb = this.objects[i];
            if (bomb == null)
            {
                this.objects.RemoveAt(i);
            }
        }
    }
}
