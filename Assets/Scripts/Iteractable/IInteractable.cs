using System.Collections.Generic;

public interface IInteractable
{
    void Pickup(Dictionary<string, ItemData> hands, string hand);
    ItemData GetItemData();
}
