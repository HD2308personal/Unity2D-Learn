using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadDespawner : MonoBehaviour
{
    protected float distance = 0;
    protected float despawnDistance = 70;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.RemoveRoad();
    }

    protected virtual void RemoveRoad()
    {
        this.distance = Vector2.Distance(PlayerController.instance.transform.position, transform.position);
        if (this.distance > this.despawnDistance)
        {
            this.Despawn();
        }
    }

    protected virtual void Despawn()
    {
        Destroy(gameObject);
    }
}
