using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class EntityModule : Installer
{
    [ShowInInspector] //Odin
    private List<Component> components = new List<Component>();

    [ShowInInspector] //Odin
    private Dictionary<string, int> _attributes = new Dictionary<string, int>();
    private void OnValidate()
    {
        components = new List<Component>
    {
        new GeneticInstaller()
    };
    }

    protected override Component SetupLoader()
    {
        Component installer = new HumanInstaller(components);
        return installer;
    }



}
