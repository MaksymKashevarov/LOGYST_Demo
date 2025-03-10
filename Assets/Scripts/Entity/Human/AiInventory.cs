using Entity.InventorySystem;
using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]

public class AiInventory : Inventory
{
    private readonly List<ItemData> inventory;
    public AiInventory(List<ItemData> inventory) 
    {
        this.inventory = inventory;
    }

    public override void Refresh()
    {
        if (inventory != null && inventory.Count > 0)
        {
            for (int i = inventory.Count - 1; i >= 0; i--)
            {
                if (inventory[i] == null)
                {
                    Debug.LogWarning("Null Item Deleted");
                    inventory.RemoveAt(i);
                }
            }
        }

    }
}
