using Entity.InventorySystem;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour, IInteractable
{
    [SerializeField] private ItemData data;
    public void Pickup(Dictionary<string, ItemData> hands, string hand)
    {
        Debug.Log("I WAS PICKED UP!");
        hands[hand] = data;
        Destroy(gameObject);
    }
    public ItemData GetItemData()
    {
        return data;
    }

}
