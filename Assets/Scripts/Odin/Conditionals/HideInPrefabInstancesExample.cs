using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInPrefabInstancesExample : MonoBehaviour
{
    [HideInPrefabInstances]
    public GameObject HiddenInPrefabInstances;
}
