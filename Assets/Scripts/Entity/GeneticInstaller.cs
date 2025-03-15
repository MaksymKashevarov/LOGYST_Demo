using System.Collections.Generic;
using UnityEngine;

public class GeneticInstaller : Component
{
    private readonly Dictionary<int, string> _attributes;
    public override void Install()
    {
        Debug.Log("Me Installed!");
    }

    public override void LoadFirst()
    {
        Debug.Log("Me Loaded First!");
    }
}
