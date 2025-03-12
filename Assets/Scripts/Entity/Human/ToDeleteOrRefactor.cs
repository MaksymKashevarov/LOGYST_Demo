using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class ToDeleteOrRefactor : MonoBehaviour
{
    [SerializeField] private List<ItemData> _inventory;
    [Header("Hands")]
    [SerializeField] private Dictionary<string, ItemData> hands = new Dictionary<string, ItemData>();
    [Header("AI Configuration")]
    //[SerializeField] private float _maxCarryWeight = 15f;
    [SerializeField] private float _health;
    //[SerializeField] private int _maxInvSlots;
    private AiInventory _aiInventory;
    private Hands _hands;

    private void Awake()
    {
        _inventory = new List<ItemData>();
        _aiInventory = new AiInventory(_inventory);
        hands = new Dictionary<string, ItemData>
        {
            { "RHand", null },
            { "LHand", null }
        };
        _hands = new Hands(hands); 
    }
    public void PrintHands()
    {
        foreach (var pair in hands)
        {
            Debug.Log($"Рука: {pair.Key}, Предмет: {(pair.Value != null ? pair.Value.name : "Пусто")}");
        }
    }



    private void Update()
    {
        _aiInventory.Refresh();
        PrintHands();
    }

    public Hands GetHands()
    {
        return _hands;
    }

}

