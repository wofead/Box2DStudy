using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TypeInfoBox("这里是使用自定义和属性Drawer绘制的HealthBar栏可视化")]
public class CustomDrawerExample : MonoBehaviour
{
    [HealthBar(100)]
    public float Health;

    public MyStruct MyStruct;
    [ShowInInspector]
    public static float labelWidth = 10f;
}

[Serializable]
public struct MyStruct
{
    public float X;
    public float Y;
}