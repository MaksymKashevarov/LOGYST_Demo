using Entity.InventorySystem;
using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private List<ItemData> _inventory;
    [SerializeField] private int _maxInvSlots;
    private AiInventory _aiInventory;
    private float _rayDistance = 3f;



    private void Start()
    {
        _inventory = new List<ItemData>();
        _aiInventory = new AiInventory(_inventory);
    }

    public void Interact()
    {
        RaycastHit hit;
        float heightOffset = 1.0f;
        float radius = 0.5f;

        Vector3 startPoint = transform.position + Vector3.up * heightOffset;
        Vector3 endPoint = transform.position - Vector3.up * heightOffset;

        Debug.DrawRay(transform.position, transform.forward * _rayDistance, Color.red);

        if (Physics.CapsuleCast(startPoint, endPoint, radius, transform.forward, out hit, _rayDistance))
        {
            Iteractable _obj = hit.collider.GetComponent<Iteractable>();
            if (_obj != null)
            {
                _obj.Pickup(_inventory);
            }
        }
    }

    private void Update()
    {
        _aiInventory.Refresh();
    }



}
