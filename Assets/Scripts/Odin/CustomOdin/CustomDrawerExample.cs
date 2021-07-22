using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[TypeInfoBox("这里是使用自定义和属性Drawer绘制的HealthBar栏可视化")]
public class CustomDrawerExample : MonoBehaviour
{
    [HealthBar(100)]
    public float Health;
}
