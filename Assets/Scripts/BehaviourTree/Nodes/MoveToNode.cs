using BehaviourTree;
using UnityEngine;
using UnityEngine.AI;

public class MoveToNode : Node
{
    private Vector3 target;
    private NavMeshAgent agent;
    private bool isMoving = false;

    public MoveToNode(Vector3 target, NavMeshAgent agent)
    {
        this.target = target;
        this.agent = agent;
    }

    public override NodeState Evaluate()
    {
        if (target == null)
        {
            state = NodeState.Failed;
            return state;
        }

        if (!isMoving)
        {
            agent.SetDestination(target);
            isMoving = true;
        }

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            isMoving = false;
            state = NodeState.Success;
            return state;
        }

        state = NodeState.Running;
        return state;
    }
}
