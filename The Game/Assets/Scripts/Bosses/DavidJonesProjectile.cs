using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class davidJonesProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform spawnTransfrom;
    public float force = 500f;

    [SerializeField] private float ShootCooldown = 2f;

    [SerializeField] private float Timer = 0f;

    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0f)
        {
            Shoot();
            Timer = ShootCooldown;
        }
    }

    void Shoot()
    {

        GameObject newProjectile = Instantiate(projectilePrefab, spawnTransfrom.position, spawnTransfrom.rotation);
        Rigidbody rigid = newProjectile.GetComponent<Rigidbody>();

        if (rigid != null)
        {
            rigid.velocity = spawnTransfrom.forward * force;
        }
    }
}