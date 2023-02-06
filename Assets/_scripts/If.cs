using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLocaltion = 19;
        int spawnLocation = 20;
        if (playerLocaltion == spawnLocation)
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
    }

    void NotSpawn()
    {
        Debug.Log("Not Spawn");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
