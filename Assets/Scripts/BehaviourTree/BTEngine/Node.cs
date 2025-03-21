using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

namespace BehaviourTree
{
    public enum NodeState
    {
        Success,
        Running,
        Failed
    }
    public class Node
    {
        protected NodeState state;

        public Node parent;
        protected List<Node> children = new List<Node>();

        public Node()
        {
            parent = null;
        }

        public Node(List<Node> children)
        {
            foreach (Node child in children)
                Attach(child);
        }

        private void Attach(Node node)
        {
            node.parent = this;
            children.Add(node);
        }

        public virtual NodeState Evaluate() => NodeState.Failed;
    }
}
