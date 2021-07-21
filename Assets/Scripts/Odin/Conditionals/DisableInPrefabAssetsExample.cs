using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInPrefabAssetsExample : MonoBehaviour
{
    [InfoBox("这些属性只有在检查GameObject的组件时才会起作用。")]

    [DisableInPrefabAssets] // 在asset中且为预制体时，这个属性被警用
    public GameObject DisabledInPrefabAssets;
}
