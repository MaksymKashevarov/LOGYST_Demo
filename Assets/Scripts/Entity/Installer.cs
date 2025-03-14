using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class Installer : MonoBehaviour
{
    private Creature loader;

    protected void Start()
    {
        loader = SetupLoader();
        if (loader != null)
        {
            Debug.Log("Loader Located Succesfully!");
            loader.LoadFirst();
            loader.Install();
            Debug.Log("Loaded Succesfully!");
        }
    }

    protected abstract Creature SetupLoader();
}
