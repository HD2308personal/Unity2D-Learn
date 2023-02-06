using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [SerializeField]private int HealthPoint = 6;

    public int HealthPointAttribute
    {
        get { return HealthPoint; }
        set { HealthPoint = value; }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void ReceiveDamage(int damage)
    {
        this.HealthPoint -= damage;
    }

    public virtual bool isDead()
    {
        return this.HealthPoint <= 0;
    }
}
