using Sirenix.OdinInspector;
using UnityEngine;
using System;

public class TypeInfoBoxExample : MonoBehaviour
{
    public MyType MyObject = new MyType();

    [InfoBox("双击此段的Value值，可在inspector中查看对应ScriptableObject信息")]
    public MyScripty Scripty = null;
    public void Awake()
    {
        Scripty = ScriptableObject.CreateInstance<MyScripty>();
    }

    [Serializable]
    [TypeInfoBox("TypeInfoBox特性可以放在类型定义上，并将导致在属性的顶端处绘制一个InfoBox。")]
    public class MyType
    {
        public int Value;
    }
}
