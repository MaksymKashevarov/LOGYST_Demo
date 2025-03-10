using System.Collections.Generic;
using UnityEngine;

public class ObjectInstaller : Installer
{
    //[SerializeField] private ObjectPattern pattern;
    [SerializeField] private string patternKey;
    private Dictionary<string, int> geneticDict = new Dictionary<string, int>();

    protected override void InstallCharacter()
    {
        GeneticTemplate.ReceiveTemplate(geneticDict, patternKey);
    }

    private void Start()
    {
        InstallCharacter();
    }
}

