using UnityEngine;
using BehaviourTree;
using System.Collections.Generic;
using BehaviorTree.Nodes;
using BehaviorTree;
using UnityEngine.AI;

public class HumanBT : Root
{
    [SerializeField] private List<Transform> _locations;
    private NavMeshAgent _agent;
    private Human _human;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _human = GetComponent<Human>();
        if (_human is null)
        {
            Debug.LogWarning("Couldn't load Human component!");
        }
    }

    protected override Node SetupTree()
    {
        Node root = new Sequence(new List<Node>
        {
            new SphereScanNode(gameObject.transform.position, 25f, "Cargo",_locations, 1),
            new MoveToNode(_locations, _agent),
            new PickUpNode(_human, _agent)
        });;
        return root;
    }
}
