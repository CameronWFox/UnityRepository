using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public Transform[] patrolPoints;

    private NavMeshAgent patrolAgent;
    private int destinationPatrolPoint = 0;
    private InputMasterControls inputMasterControls;

    void Awake()
    {
        inputMasterControls.AI.Patrol.performed += performPatrol => OnPatrol();
        inputMasterControls.AI.Patrol.canceled += cancelPatrol => Canceled();
    }

    // Start is called before the first frame update
    void Start()
    {
        patrolAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPatrol()
    {

    }

    void Canceled()
    {

    }
}
