using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInPrefabsExample : MonoBehaviour
{
    [DisableInPrefabs]//只要是预制体，就隐藏此属性，不管是否在asset还是hierarchy
    public GameObject DisabledInPrefabs;
}
