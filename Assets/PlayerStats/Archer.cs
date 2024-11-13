using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : PlayerStats
{
    private void Start()
    {
        Attack();
        Jumps();
        Debug.Log("Health:" + health);
    }

    protected override void Jumps()
    {
        Debug.Log("Archer jumps");
    }

    protected override void Attack()
    {
        Debug.Log("Archer attacks NA");
    }
    

}
