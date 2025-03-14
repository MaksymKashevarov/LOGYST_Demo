using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class EntityModule : Installer
{
    [ShowInInspector]
    private Dictionary<string, int> _attributes;
    private List<Creature> list = new List<Creature>();

    protected override Creature SetupLoader()
    {
        HumanInstaller humanInstaller = new HumanInstaller(
            list);
        return humanInstaller;
    }

    private void Awake()
    {
        _attributes = new Dictionary<string, int>();
    }

}
