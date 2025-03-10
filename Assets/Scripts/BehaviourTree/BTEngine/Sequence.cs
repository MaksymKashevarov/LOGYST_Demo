using BehaviourTree;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Metadata;

namespace BehaviorTree
{
    public class Sequence : Node
    {
        private int _currentIndex = 0;

        public Sequence(List<Node> children) : base(children) { }

        public override NodeState Evaluate()
        {
            if (_currentIndex >= children.Count)
            {
                _currentIndex = 0;
                return NodeState.Success;
            }

            Node node = children[_currentIndex];

            switch (node.Evaluate())
            {
                case NodeState.Failed:
                    _currentIndex = 0;
                    return NodeState.Failed;

                case NodeState.Running:
                    return NodeState.Running;

                case NodeState.Success:
                    _currentIndex++;
                    return NodeState.Running;
            }

            return NodeState.Success;
        }
    }

}