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
            Debug.Log("(Preload) Loader Located Succesfully!");
            loader.LoadFirst();            
            Debug.Log("Preloaded Succesfull!");
        }
    }

    protected void OnEnable()
    {
        if (loader != null)
        {
            Debug.Log("(Install) Loader Located Succesfully!");
            loader.Install();
            Debug.Log("Installed Succesfull!");
        }
    }

    protected abstract Component SetupLoader();
}
