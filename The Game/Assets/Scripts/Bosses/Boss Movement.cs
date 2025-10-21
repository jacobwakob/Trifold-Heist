using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    public float CloseDistance = 12f;

    private GameObject Player;

    private NavMeshAgent NavAgent;

    private Rigidbody Rigidbody;

    public bool Follow;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        NavAgent = GetComponent<NavMeshAgent>();
        Rigidbody = GetComponent<Rigidbody>();
        Follow = false;
    }

    void Update()
    {
        if (Player.GetComponent<CharacterSTATS>().IsDeadCheck())
        {
            NavAgent.isStopped = true;
            return;
        }

        float distance = Vector3.Distance(Player.transform.position, transform.position);

        NavAgent.SetDestination(Player.transform.position);
        NavAgent.isStopped = false;
    }

    private void OnEnable()
    {
        Rigidbody.isKinematic = false;
    }

    private void OnDisable()
    {
        Rigidbody.isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Follow = true;
        }
    }
}
