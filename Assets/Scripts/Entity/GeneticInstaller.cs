using System.Collections.Generic;
using UnityEngine;

public class GeneticInstaller : Component
{
    private readonly Dictionary<string, int> _attributes;

    /*public GeneticInstaller(Dictionary<string, int> _attributes)
    {
        this._attributes = _attributes;
    }
    */

    public override void LoadFirst()
    {
        Debug.Log("Me Loaded First!");
    }

    public override void Install()
    {
        Debug.Log("Me Installed!");
    }

}
