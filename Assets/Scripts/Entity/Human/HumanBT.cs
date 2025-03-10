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
    private Hands _hands;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _human = GetComponent<Human>();
        _hands = _human.GetHands();

        if (_human == null)
        {
            Debug.LogWarning("Couldn't load Human component!");
        }

        if (_hands == null)
        {
            Debug.LogWarning("Couldn't load Hands component!");
        }
    }

    protected override Node SetupTree()
    {
        Node root = new Sequence(new List<Node>
        {

        }
        );
        return root;
    }
}