using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class EntityModule : MonoBehaviour
{
    [ShowInInspector]
    private Dictionary<string, int> _attributes;

    private void Awake()
    {
        _attributes = new Dictionary<string, int>();
    }

}
