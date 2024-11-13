using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : NPCStats, iDamagable
{
    private void Start()
    {

        Hitted();
        Movement();
        Damage(30);
    }

    protected override void Movement()
    {
        Debug.Log("Goblin moves");
    }

    protected override void Hitted()
    {
        Debug.Log("Goblin got punched");
    }

    public void Damage(int Damage)
    {

        Debug.Log("Goblin Health: " + health);
        health -= Damage;
        Debug.Log("Goblin new health: " + health);
    }
}
