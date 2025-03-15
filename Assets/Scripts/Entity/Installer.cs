using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public abstract class Installer : MonoBehaviour
{
    private Component loader;

    protected void Awake()
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

    protected abstract Component SetupLoader();
}
