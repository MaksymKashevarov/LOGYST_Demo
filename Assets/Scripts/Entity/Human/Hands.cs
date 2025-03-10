using System.Collections.Generic;
using System.Linq;

public class Hands : IHands
{
    private Dictionary<string, ItemData> hands; 

    public Hands(Dictionary<string, ItemData> handsReference)
    {
        hands = handsReference; 
    }

    public string GetFreeHand(Dictionary<string, ItemData> hands)
    {
        foreach(var hand in hands)
        {
            if (hand.Value == null) 
            {
                return hand.Key; 
            }
        }
        return null;
    }

    public bool isAbleToGrab(ItemData item)
    {
        if (hands == null || hands.Count == 0)
            return false;

        switch (item.carryIndex)
        {
            case ÑarryIndex.Light:
                return hands.Any(hand => hand.Value == null);

            case ÑarryIndex.Heavy:
                return hands.All(hand => hand.Value == null);

            default:
                return false;

        }
    }

    public void Grab(IInteractable item, ItemData data)
    {
        switch (data.carryIndex)
        {
            case ÑarryIndex.Heavy:
                item.Pickup(hands, "RHand");
                SetItem("LHand");
                break;
            case ÑarryIndex.Light:
                string freeHand = GetFreeHand(hands);
                item.Pickup(hands, freeHand);
                break;
            default:
                break;
        }
    }

    public void SetItem(string hand)
    {
        if (hands.ContainsKey(hand))
        {
            string otherHand = (hand == "RHand") ? "LHand" : "RHand";

            if (hands[otherHand] != null)
            {
                hands[hand] = hands[otherHand];
            }
        }
    }
}
