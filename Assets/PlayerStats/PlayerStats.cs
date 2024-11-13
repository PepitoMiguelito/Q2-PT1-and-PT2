using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStats : MonoBehaviour
{
    [SerializeField] protected string npcName;
    [SerializeField] protected int health;
    [SerializeField] protected int attack;
    [SerializeField] protected int defense;
    [SerializeField] protected float speed;

    protected abstract void Attack();
    protected abstract void Jumps();
}
