using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercenary : NPCStats
{
    private void Start()
    {

        Hitted();
        Movement();
        Damage(30);
    }

    protected override void Movement()
    {
        Debug.Log("Mercenary moves");
    }

    protected override void Hitted()
    {
        Debug.Log("Mercenary got punched");
    }

    public void Damage(int Damage)
    {

        Debug.Log("Mercenary Health: " + health);
        health -= Damage;
        Debug.Log("Mercenary new health: " + health);
    }
}
