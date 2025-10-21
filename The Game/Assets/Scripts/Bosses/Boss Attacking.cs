using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BossAttacking : MonoBehaviour
{
    public float damageAmount = 33.5f;
    public float damageCooldown = 1.5f;

    public float damageTimer = 0f;

    private void Update()
    {
        if (damageTimer > 0f)
        {
            damageTimer -= Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider EnemyDamageCollider)
    {
        if (EnemyDamageCollider.CompareTag("Player") && damageTimer <= 0f)
        {
            CharacterSTATS playerStats = EnemyDamageCollider.GetComponent<CharacterSTATS>();
            if (playerStats != null && !playerStats.IsDeadCheck())
            {
                playerStats.TakeDamage((int)damageAmount);
                damageTimer = damageCooldown;
            }
        }
    }
}
