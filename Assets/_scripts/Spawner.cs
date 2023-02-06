using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawner")] 
    public GameObject objPrefab;

    public GameObject spawnPosition;
    
    public List<GameObject> objects;
    
    protected float spawnTimer = 0f;
    protected float spawnDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
