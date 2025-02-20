using BehaviourTree;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorTree.Nodes
{
    public class MoveToNode : Node
    {
        private readonly List<Transform> locations;
        private NavMeshAgent agent;
        private bool _isMoving = false;

        public MoveToNode(List<Transform> locations, NavMeshAgent agent) 
        {
            this.locations = locations; 
            this.agent = agent;
        } 

        public override NodeState Evaluate()
        {
            if (locations.Count == 0)
            {
                state = NodeState.Failed;
                return state;
            }

            if (!_isMoving)
            {
                agent.SetDestination(locations[0].position);
                _isMoving = true;
            }

            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                locations.RemoveAt(0);
                _isMoving = false;
                state = NodeState.Success;
                return state;
            }

            state = NodeState.Running;
            return state;
        }
    }

}
