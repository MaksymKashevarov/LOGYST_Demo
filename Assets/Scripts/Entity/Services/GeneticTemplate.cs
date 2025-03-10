using System.Collections.Generic;
using UnityEngine;

public static class GeneticTemplate
{
    public static readonly Dictionary<string, int> humanData = new Dictionary<string, int>
    {
        {"hp", 100},
        {"stamina", 100},
        {"traits_agressive", 3},
    };

    private static void InitializeDictionary(Dictionary<string, int> inputDict, Dictionary<string, int> baseData)
    {
        inputDict.Clear();
        foreach(var kvp in baseData) 
        {
            inputDict[kvp.Key] = kvp.Value;
        }
    }

    public static void ReceiveTemplate(Dictionary<string, int> inputDict, string keyword)
    {
        switch (keyword)
        {
            case "Human":
                InitializeDictionary(inputDict, humanData);
                break;
        }
    }

}
