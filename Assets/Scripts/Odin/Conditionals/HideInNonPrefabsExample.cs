using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInNonPrefabsExample : MonoBehaviour
{
    [HideInNonPrefabs] //非预制体时隐藏属性
    public GameObject HiddenInNonPrefabs;
}
