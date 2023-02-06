using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    [SerializeField]public float speed = 40f;
    [SerializeField]public float distanceLimit = 0f;
    public float randPos = 0;

    public float Speed
    {
        get { return speed;}
        set { speed = value; }
    }

    public float DistanceLimit
    {
        get { return distanceLimit; }
        set { distanceLimit = value; }
    }
    
    private void Awake()
    {
        this.player = PlayerController.instance.transform;
        this.randPos = Random.Range(-6, 6);
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
        this.Follow();
    }

    void Follow()
    {
        Vector3 pos = this.player.position;
        // pos.x = this.randPos;
        Vector3 distance = this.player.position - transform.position;
        if (distance.magnitude >= this.distanceLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.distanceLimit;
            transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }

    }
}
