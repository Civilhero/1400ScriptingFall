using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patroller : MonoBehaviour
{
    public Transform[] WayPointer;
    private int CurrentTarget;
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (WayPointer.Length > 0)
        {
            agent.SetDestination(WayPointer[0].position);
        }
    }

    void Update()
    {
     if (agent.remainingDistance < agent.stoppingDistance)
     {
         CurrentTarget = (CurrentTarget + 1) % WayPointer.Length;
         agent.SetDestination(WayPointer[CurrentTarget].position);
     }
    }
}
