using BehaviourTree;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree.Nodes
{
    public class SphereScanNode : Node
    {
        private Vector3 position;
        private float radius;
        private string tag;
        private readonly List<Transform> locations;
        private int maxMemory;

        public SphereScanNode(Vector3 position, float radius, string tag, List<Transform> locations, int maxMemory)
        {
            this.position = position;
            this.radius = radius;
            this.tag = tag;
            this.locations = locations;
            this.maxMemory = maxMemory;
        }

        public void DrawRayCast()
        {
            Collider[] hits = Physics.OverlapSphere(position, radius);

            foreach (Collider hit in hits)
            {
                if (hit.CompareTag(tag))
                {
                    if (!locations.Contains(hit.transform))
                    {
                        locations.Add(hit.transform);
                    }
                }
            }
        }

        public override NodeState Evaluate()
        {
            DrawRayCast();

            if (locations.Count >= maxMemory)
            {
                state = NodeState.Success;
                return state;
            }
            if (locations.Count > 0)
            {
                return NodeState.Running;
            }

            Debug.LogWarning("Failed!");
            locations.Clear();
            state = NodeState.Failed;
            return state;
        }
    }
}

