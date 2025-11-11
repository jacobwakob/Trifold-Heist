using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billyProjectile : MonoBehaviour
{
    public GameObject projectilePrefab1;
    public Transform spawnTransfrom1;
    public float force = 500f;

    [SerializeField] private float ShootCooldown = 0.5f;

    [SerializeField] private float Timer = 0f;

    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0f)
        {
            Shoot1();
            Timer = ShootCooldown;
        }
    }

    void Shoot1()
    {

        GameObject newProjectile1 = Instantiate(projectilePrefab1, spawnTransfrom1.position, spawnTransfrom1.rotation);
        Rigidbody rigid1 = newProjectile1.GetComponent<Rigidbody>();

        if (rigid1 != null)
        {
            rigid1.velocity = spawnTransfrom1.forward * force;
        }
    }
}