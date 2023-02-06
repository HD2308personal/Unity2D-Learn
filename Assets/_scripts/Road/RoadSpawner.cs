using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    protected GameObject roadPrefab;

    protected GameObject roadSpawnPosition;

    protected float distance = 0;

    protected GameObject currentRoad;

    private void Awake()
    {
        this.roadPrefab = GameObject.Find("RoadPrefab");
        this.roadSpawnPosition = GameObject.Find("RoadSpawnPosition");
        this.roadPrefab.gameObject.SetActive(false);

        // this.currentRoad = this.roadPrefab;
        this.Spawn(this.roadPrefab.transform.position);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.UpdateRoad();
    }

    protected virtual void UpdateRoad()
    {
        this.distance = Vector2.Distance(
            PlayerController.instance.transform.position,
            this.currentRoad.transform.position
        );

        if (this.distance > 40)
        {
            this.Spawn();
        }
    }

    protected virtual void Spawn()
    {
        Vector3 pos = this.roadSpawnPosition.transform.position;
        pos.x = 0;
        
        this.Spawn(pos);
        // this.currentRoad = Instantiate(
        //     this.roadPrefab, 
        //     pos,
        //     this.roadPrefab.transform.rotation
        // );
    }

    protected virtual void Spawn(Vector3 position)
    {
        this.currentRoad = Instantiate(this.roadPrefab, position, this.roadPrefab.transform.rotation);
        this.currentRoad.transform.parent = transform;
        this.currentRoad.SetActive(true);
    }
    
    
}
