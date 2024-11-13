using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : NPCStats
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
        Debug.Log("Mercenary Talks");
    }
    
}
