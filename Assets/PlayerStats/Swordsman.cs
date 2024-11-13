using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : PlayerStats
{

    private void Start()
    {
        Attack();
        Jumps();
        Debug.Log("Health:" + health);
    }

    protected override void Jumps()
    {
        Debug.Log("Swordsman jumps");
    }

    protected override void Attack()
    {
        Debug.Log("Swordsman attacks NA");
    }

    
}
