using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class EntityModule : Installer
{
    [ShowInInspector]
    private List<Component> components = new List<Component>
    {
        new GeneticInstaller(),
    };

    [ShowInInspector]
    private Dictionary<string, int> _attributes = new Dictionary<string, int>();


    protected override Component SetupLoader()
    {
        Component installer = new HumanInstaller(components);
        return installer;
    }



}
