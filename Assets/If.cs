using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLocaltion = 20;
        int spawnLocation = 20;
        if (playerLocaltion == spawnLocation)
        {
            this.Spawn();
        }
    }

    void Spawn()
    {
        Debug.Log("Spawn");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}