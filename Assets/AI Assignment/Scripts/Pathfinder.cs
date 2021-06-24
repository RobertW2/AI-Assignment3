using System.Linq;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Pathfinder : MonoBehaviour
{
    public PathfindingNode[] nodes;
    public int nodeIndex;

    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        nodeIndex = 0;
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
        if(nodeIndex < nodes.Length)
        {
            agent.SetDestination(nodes[nodeIndex++].Position);
        }
    }
}
