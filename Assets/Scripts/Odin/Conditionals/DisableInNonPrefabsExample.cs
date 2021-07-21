using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInNonPrefabsExample : MonoBehaviour
{
    [InfoBox("这些属性只有在检查GameObject的组件时才会起作用。")]

    [DisableInNonPrefabs] // 当不是预制体是灰态此属性
    public GameObject DisabledInNonPrefabs;
}
