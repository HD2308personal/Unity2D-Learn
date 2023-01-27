using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private float playerPosX;
    private List<GameObject> minions;
    public GameObject minionPerfab;
    
    // Start is called before the first frame update
    void Start()
    {
        this.minions = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.playerPosX = transform.position.x;
        // int playerLocaltion = 19;
        int spawnLocation = 7;
        if (this.playerPosX >= spawnLocation)
        {
            this.Spawn();
        }
        else
        {
            this.NotSpawn();
        }
        
        this.CheckMinionDead();
    }
    
    void Spawn()
    {
        Debug.Log("Spawn");
        if (this.minions.Count >= 7) return;
        GameObject minion = Instantiate(this.minionPerfab);
        minion.name = "MinionPrefab #" + this.minions.Count;
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

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }
}
