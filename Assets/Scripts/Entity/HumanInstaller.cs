using System.Collections.Generic;
using UnityEngine;

public class HumanInstaller : Creature
{
    public HumanInstaller(List<Creature> components) : base(components){}

    public override void Install()
    {
        foreach (var component in components)
        {
            component.Install();
        }
    }

    public override void LoadFirst()
    {
        foreach(var component in components)
        {
            component.LoadFirst();
        }
    }
}
