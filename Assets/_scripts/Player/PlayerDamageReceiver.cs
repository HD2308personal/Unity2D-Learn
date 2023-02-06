using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageReceiver : DamageReceiver
{
    protected PlayerController playerController;

    private void Awake()
    {
        this.playerController = GetComponent<PlayerController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void ReceiveDamage(int damage)
    {
        base.ReceiveDamage(damage);
        if (this.isDead())
        {
            this.playerController.playerStatus.Dead();
            UIManager.instance.btnGameOver.SetActive(true);
        }
    }
}
