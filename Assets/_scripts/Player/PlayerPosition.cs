using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private List<GameObject> minions;
    public GameObject minionPerfab;
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.Spawn();
        
        this.CheckMinionDead();
    }
    
    void Spawn()
    {
        this.spawnTimer += Time.deltaTime;
        if(this.spawnTimer < this.spawnDelay) return;

        this.spawnTimer = 0f;
        if (this.minions.Count >= 7) return;
        GameObject minion = Instantiate(this.minionPerfab);
        minion.name = "Bomb #" + this.minions.Count;
        minion.transform.position = transform.position;
        minion.gameObject.SetActive(true);
        this.minions.Add(minion);
    }

    void CheckMinionDead()
    {
        GameObject minion;
        for (int i = 0; i < this.minions.Count; i++)
        {
            minion = this.minions[i];
            if (minion == null) this.minions.RemoveAt(i);
        }
    }
}
