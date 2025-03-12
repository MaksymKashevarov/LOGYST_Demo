using BehaviourTree;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviorTree.Nodes
{
    public class PickUpNode : Node
    {
        private ToDeleteOrRefactor human;
        private Hands hands;
        public PickUpNode(ToDeleteOrRefactor human, Hands hands)
        {
            this.human = human; 
            this.hands = hands;
        }

        public bool CapsuleRaycast(float radius, float maxDistance, out RaycastHit hit, LayerMask layerMask)
        {
            Vector3 point1 = human.transform.position + Vector3.up * 0.5f;
            Vector3 point2 = human.transform.position - Vector3.up * 0.5f;
            Vector3 direction = human.transform.forward;

            return Physics.CapsuleCast(point1, point2, radius, direction, out hit, maxDistance, layerMask);
        }

        public override NodeState Evaluate()
        {
            RaycastHit hit;
            float radius = 0.3f;
            float maxDistance = 2f;
            LayerMask layerMask = LayerMask.GetMask("Interactable");

            if (CapsuleRaycast(radius, maxDistance, out hit, layerMask))
            {
                Debug.Log("Обнаружен объект: " + hit.collider.name);
                IInteractable item = hit.collider.GetComponent<IInteractable>();
                if (item != null)
                {
                    ItemData data = item.GetItemData();
                    if (data != null && hands.isAbleToGrab(data))                        
                    {
                        hands.Grab(item, data);
                        return NodeState.Success;
                    }
                    else
                    {
                        return NodeState.Failed;
                    }

                }
            }
            return NodeState.Running;
        }
    }
}
