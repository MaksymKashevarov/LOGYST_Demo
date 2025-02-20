using System.Collections.Generic;
using UnityEngine;

public class Iteractable : MonoBehaviour, IIteractable
{
    [SerializeField] private ItemData data;
    public void Pickup(List<ItemData> inventory)
    {
        inventory.Add(data);
        Destroy(gameObject);
    }
}
