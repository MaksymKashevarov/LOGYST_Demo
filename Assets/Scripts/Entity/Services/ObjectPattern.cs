using UnityEngine;

[CreateAssetMenu(fileName = "InstancePattern", menuName = "AI/Pattern")]
public class ObjectPattern : ScriptableObject
{
    public string typeName;
    public ObjectType objectType;

}

public enum ObjectType 
{ 
    Human
}