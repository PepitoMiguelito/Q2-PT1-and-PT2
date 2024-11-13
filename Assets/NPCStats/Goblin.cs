using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats, iDamagable
{
  private void Start()
    {
        Talks();
        Attack();
        Debug.Log("Health:" + health);
    }

    protected override void Attack()
    {
        Debug.Log("Mercenary hits Goblin");
    }

    protected override void Talks()
    {
        Debug.Log("Mercenary walks");
    }

    public void Damage(int damage)
    {
        Debug.Log("Goblin health" + health);
        health -= damage;
        Debug.Log("Skeleton Health" + health);
        

        
    }
}
