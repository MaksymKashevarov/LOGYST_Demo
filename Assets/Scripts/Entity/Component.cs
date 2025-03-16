using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Component
{
    protected List<Component> components = new List<Component>();
    public virtual void Install(){}

    public virtual void LoadFirst(){}

    public Component() { }

    public Component(List<Component> components)
    {
        foreach(Component comp in components) 
        {
            this.components.Add(comp);
        }

    }

}
