using Sirenix.OdinInspector;
using Sirenix.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableInPrefabInstancesExample : MonoBehaviour
{
    [DisableInPrefabInstances]//在hierarchy中为预制体时则禁用此属性
    public GameObject DisabledInPrefabInstances;
}
