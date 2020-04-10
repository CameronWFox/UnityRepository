using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public Transform[] movementPoints;
    private int destinationMovementPoint = 0;
    private NavMeshAgent movementAgent;

    private bool movePatrol = true;
    private bool moveWander = false;
    private bool moveSearch = false;

    private float minX;
    private float maxX;

    private float minZ;
    private float maxZ;

    void Start()
    {
        movementAgent = GetComponent<NavMeshAgent>();
        // Disabling auto-breaking allows for continuous movement between points
        // (ie the agent will not slow down when reaching the aprouching destination point).
        movementAgent.autoBraking = false;

        minX = -49.0f;
        maxX = 49.0f;

        minZ = -49.0f;
        maxZ = 49.0f;

        MoveToNextPatrolPoint();
    }

    void Update()
    {

        // Choose the next destination point when the agent gets close to the current one.
        if (Input.GetKeyDown(KeyCode.P) || (!movementAgent.pathPending && movementAgent.remainingDistance <= 0.5f) && (movePatrol == true))
        {
            MoveToNextPatrolPoint();
        }

        if (Input.GetKeyDown(KeyCode.W) || (moveWander == true))
        {
            MoveToNextWanderPoint();
        }

        if (Input.GetKeyDown(KeyCode.S) || (moveSearch == true))
        {
            MoveToNextSearchPoint();
        }

    }

    void MoveToNextPatrolPoint()
    {
        movePatrol = true;
        moveWander = false;
        moveSearch = false;
        // Returns if no points have been set up for patrol
        if (movementPoints.Length == 0)
        {
            return;
        }

        // Set the patrolAgent to go to the currently selected destination point.
        movementAgent.destination = movementPoints[destinationMovementPoint].position;

        // Choose the next point in the array as the destination, cycling to the start if necessary.
        destinationMovementPoint = (destinationMovementPoint + 1) % movementPoints.Length;
    }

    void MoveToNextWanderPoint()
    {
        movePatrol = false;
        moveWander = true;
        moveSearch = false;
        // Set the patrolAgent to go to the currently selected destination point.
        movementAgent.destination = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
    }

    void MoveToNextSearchPoint()
    {
        movePatrol = false;
        moveWander = false;
        moveSearch = true;
        // Here the AI will enter a search move to hunt a target that was detected.
        // If target not detected after a time then leave Search Mode and enter Patrol Mode.
    }
}
