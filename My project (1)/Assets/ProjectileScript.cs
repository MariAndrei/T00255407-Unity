using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDmg : MonoBehaviour
{
    [Header("Settings")]
    public int damage;
    public bool destroyOnHit;

    private Rigidbody rb;

    private bool hitTarget;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (hitTarget)
            return;
        else
            hitTarget = true;

        // check if you hit an enemy
        if (collision.gameObject.GetComponent<Target>() != null)
        {
            Target enemy = collision.gameObject.GetComponent<Target>();

            enemy.TakeDamage(damage);

            if (destroyOnHit)
                Destroy(gameObject);
        }


        
    }
}