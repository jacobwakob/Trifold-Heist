using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossProjectile : MonoBehaviour
{
    public float projectileLife = 3;
    public int damageAmount = 60;

    void Start()
    {
        Destroy(gameObject, projectileLife);
    }

    private void OnCollisionEnter(Collision collision)
    {
        WizardSTATS targetHit = collision.gameObject.GetComponent<WizardSTATS>();
        if (targetHit != null)
        {
            Debug.Log("HIT!!!!");
            targetHit.TakeDamage(damageAmount);
        }

        Destroy(gameObject);
    }
}