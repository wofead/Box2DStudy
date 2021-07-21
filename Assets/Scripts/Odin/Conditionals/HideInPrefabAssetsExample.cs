using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInPrefabAssetsExample : MonoBehaviour
{
    [HideInPrefabAssets] //在Asset中且是预制体时隐藏
    public GameObject HiddenInPrefabAssets;
}
