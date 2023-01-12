using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    private float playerPosX;
    private List<GameObject> minions;
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
    }
    
    void Spawn()
    {
        Debug.Log("Spawn");
        if (this.minions.Count >= 7) return;
        GameObject minion = new GameObject("Minion", typeof(If));
        this.minions.Add(minion);
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }
}
