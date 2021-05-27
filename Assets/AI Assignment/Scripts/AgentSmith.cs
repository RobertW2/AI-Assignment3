using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class AgentSmith : MonoBehaviour
{

    private NavMeshAgent agent;
    private WayPoint[] wayPoints;

    // Will give us a random waypoint in the array as a variabl everytime i access it
    private WayPoint RandomPoint => wayPoints[Random.Range(0, wayPoints.Length)];

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        // FindObjectsOfType gets every instance of this component in the scene
        wayPoints = FindObjectsOfType<WayPoint>();

        // Tell the agent to move to a random position in the scene waypoints
        agent.SetDestination(RandomPoint.Position);
    }

    // Update is called once per frame
    void Update()
    {
        // Has the agent reached it's position?
        if(!agent.pathPending && agent.remainingDistance < 0.1f)
        {

            // Tell the agent to move to a random position in the scene waypoints
            agent.SetDestination(RandomPoint.Position);
        }
    }


}
