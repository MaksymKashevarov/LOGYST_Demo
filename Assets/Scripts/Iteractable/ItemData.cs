using UnityEngine;


[CreateAssetMenu(fileName = "AiData", menuName = "AI/Data")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public float weight;
    public ÑarryIndex carryIndex;
    public GameObject objectPrefab;


}

public enum ÑarryIndex
{
    Light,
    Heavy
}