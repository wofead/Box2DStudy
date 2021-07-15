﻿using Sirenix.OdinInspector;
using UnityEngine;

public class ChildGameObjectOnly : MonoBehaviour
{
    [ChildGameObjectsOnly]
    public GameObject ChildGameObject;

    [ChildGameObjectsOnly(IncludeSelf = false)]//是否包含顶层定节点
    public Transform ChildOrSelfTransform;
}
