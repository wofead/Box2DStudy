﻿using Sirenix.OdinInspector;
using UnityEngine;

public class ShowInInspectorExample : MonoBehaviour
{
    [ShowInInspector]
    private int myPrivateInt;

    [ShowInInspector]
    public int MyPropertyInt { get; set; }

    [ShowInInspector]
    public int ReadOnlyProperty
    {
        get { return this.myPrivateInt; }
    }

    [ShowInInspector]
    public static bool StaticProperty { get; set; }

    private void Start()
    {
        Debug.Log($"{MyPropertyInt}");
    }
}
