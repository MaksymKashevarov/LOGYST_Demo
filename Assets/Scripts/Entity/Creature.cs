using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Creature
{
    protected List<Creature> components = new List<Creature>();
    public virtual void Install(){}

    public virtual void LoadFirst(){}

    public Creature(List<Creature> components)
    {
        foreach(Creature comp in components) 
        {
            this.components.Add(comp);
        }

    }

}
