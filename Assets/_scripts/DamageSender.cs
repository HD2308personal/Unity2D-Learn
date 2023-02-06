using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : MonoBehaviour
{
    protected EnemyController enemyController;

    private void Awake()
    {
        this.enemyController = GetComponent<EnemyController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        if (damageReceiver == null)
        {
            return;
        }
        damageReceiver.ReceiveDamage(1);
        
        EffectManager.instance.SpawnVFX("Explose_A", transform.position, transform.rotation);
        this.enemyController.despawner.Despawn();
    }
}
