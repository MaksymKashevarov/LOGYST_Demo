using BehaviourTree;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorTree.Nodes
{
    public class PickUpNode : Node
    {
        private Human _human;
        private NavMeshAgent _agent;
        public PickUpNode(Human _human, NavMeshAgent _agent)
        {
            this._human = _human;
            this._agent = _agent;
        }

        public override NodeState Evaluate()
        {
            if (_agent.remainingDistance <= _agent.stoppingDistance)
            {
                _human.Interact();
                state = NodeState.Success;
            }
            else
            {
                Debug.LogWarning("Can't be done!");
                state = NodeState.Failed;
            }
            return state;
        }
    }
}
