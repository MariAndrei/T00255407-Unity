using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Target : MonoBehaviour
{
    [Header("Stats")]
    public int health;

    public bool IsDead { get; private set; }
    

    public void TakeDamage(int damage)
    {

        health -= damage;

        if (health <= 0)
            DestroyEnemy();
    }

    
    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}