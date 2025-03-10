using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Genome", menuName = "AI/Genome")]
public class GeneticCode : ScriptableObject
{
    public string geneticName;

    [ShowInInspector]
    public Dictionary<string, int> genCode = new Dictionary<string, int>();

}
