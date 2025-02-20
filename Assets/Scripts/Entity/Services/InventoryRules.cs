using System.Collections.Generic;
using UnityEngine;

public class InventoryRules
{
    private ItemData _item;
    private List <ItemData> _items;
    public InventoryRules(ItemData _item, List<ItemData> _items) 
    {
        this._item = _item;
        this._items = _items;
    }

    public bool isCarryOnly(ItemData item)
    {
        if (item.carryIndex > 1)
        {
            return true;
        }
        return false;       
    }

    public bool isOneHand(ItemData item)
    {
        if (item.carryIndex == 1)
        {
            return true;
        }
        return false;
    }

    public bool hasItem(List<ItemData> item, int index)
    {
        if (item[index].carryIndex >= 1)
        {
            return true;
        }
        return false;
    }
}
