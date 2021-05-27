using System.Linq;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Pathfinder : MonoBehaviour
{
    private PathfindingNode[] nodes;
    private int nodeIndex;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        nodes = FindObjectsOfType<PathfindingNode>();
        nodes = nodes.OrderBy(_node => _node.gameObject.name).ToArray();

        UpdatePath();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.remainingDistance <= .1f && !agent.pathPending)
        {
            UpdatePath();
        }
    }

    private void UpdatePath()
    {
        agent.SetDestination(nodes[nodeIndex++].Position);
    }
}
