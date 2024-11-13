using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPCStats : MonoBehaviour
{
    [SerializeField] protected string npcName;
    [SerializeField] protected int health;
    [SerializeField] protected int attack;
    [SerializeField] protected int defense;
    [SerializeField] protected float speed;

    protected abstract void Talks();
    protected abstract void Attack();


}
